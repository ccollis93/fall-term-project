using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

using bitsHomePageUWP.Models;
using bitsHomePageUWP.Services;
using System.Collections.ObjectModel;
using Windows.UI.Popups;
using System.Net.Http;

namespace bitsHomePageUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SupplierPage : Page
    {
        private Supplier selected = null;
        private HttpDataService service;
        

        public Supplier Selected
        {
            get { return selected; }
            set { selected = value; }
        }

        public ObservableCollection<Supplier> Suppliers { get; private set; } = new ObservableCollection<Supplier>();

        public SupplierPage()
        {
            this.InitializeComponent();
        }


        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
          
            service = new HttpDataService("http://localhost:5000/api");
            List<Supplier> suppliers = await service.GetAsync<List<Supplier>>("supplier");
            foreach (Supplier s in suppliers)
                this.Suppliers.Add(s);
            ClearSupplierDetails();
            EnableFields(false);
            EnableButtons("pageLoad");
        }

        private async void findBtn_Click(object sender, RoutedEventArgs e)
        {
            string supplierId = this.supplierIdTxt.Text;
            try
            {
                Selected = await service.GetAsync<Supplier>("supplier\\" + supplierId, null, true);
                DisplaySupplierDetails();
                EnableButtons("found");
            }
            catch
            {
                var messageDialog = new MessageDialog("No Supplier with that ID exists.");
                await messageDialog.ShowAsync();
                Selected = null;
                ClearSupplierDetails();
            }
        }

        private async void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Selected != null)
            {
                int supplierId = Selected.SupplierId;

                if (await service.DeleteAsync("supplier\\" + supplierId))
                {
                    Selected = null;
                    this.supplierIdTxt.Text = "";
                    ClearSupplierDetails();
                    EnableButtons("pageLoad");
                    var messageDialog = new MessageDialog("Supplier was deleted.");
                    await messageDialog.ShowAsync();
                }
                else
                {
                    var messageDialog = new MessageDialog("Error. There was a problem deleting the supplier.");
                    await messageDialog.ShowAsync();
                }
            }
        }

        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            this.supplierIdTxt.IsEnabled = false;
            EnableFields(true);
            EnableButtons("editing");
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            Selected = null;
            this.supplierIdTxt = null;
            this.supplierIdTxt.IsEnabled = false;
            ClearSupplierDetails();
            EnableFields(true);
            EnableButtons("adding");
        }

        private async void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Selected == null)
            {
                Supplier newSupplier = new Supplier();
                newSupplier.Name = this.supplierNameTxt.Text;
                newSupplier.Phone = this.supplierNameTxt.Text;
                newSupplier.Email = this.supplierEmailTxt.Text;
                newSupplier.Website = this.supplierWebsiteTxt.Text;
                newSupplier.ContactFirstName = this.contactFirstNameTxt.Text;
                newSupplier.ContactLastName = this.contactLastNameTxt.Text;
                newSupplier.ContactPhone = this.contactPhoneTxt.Text;
                newSupplier.ContactEmail = this.contactEmailTxt.Text;
                newSupplier.Note = this.supplierNoteTxt.Text;

                HttpResponseMessage response = await service.PostAsJsonAsync<Supplier>("supplier", newSupplier, true);

                if (response.IsSuccessStatusCode)
                {
                    string url = response.Headers.Location.AbsolutePath;
                    int index = url.LastIndexOf("/");
                    string supplierId = url.Substring(index + 1);
                    newSupplier.SupplierId = int.Parse(supplierId);
                    Selected = newSupplier;
                    this.supplierIdTxt.Text = Selected.SupplierId.ToString();
                    this.supplierIdTxt.IsEnabled = true;
                    DisplaySupplierDetails();
                    EnableButtons("found");
                    var messageDialog = new MessageDialog("New Supplier successfully added.");
                    await messageDialog.ShowAsync();
                }
                else
                {
                    var messageDialog = new MessageDialog("Error. There was a problem adding a new Supplier");
                    await messageDialog.ShowAsync();
                }  
            }
            else
            {
                Supplier updatedSupplier = new Supplier();
                updatedSupplier.SupplierId = Selected.SupplierId;
                updatedSupplier.Name = this.supplierNameTxt.Text;
                updatedSupplier.Phone = this.supplierPhoneTxt.Text;
                updatedSupplier.Email = this.supplierEmailTxt.Text;
                updatedSupplier.Website = this.supplierWebsiteTxt.Text;
                updatedSupplier.ContactFirstName = this.contactFirstNameTxt.Text;
                updatedSupplier.ContactLastName = this.contactLastNameTxt.Text;
                updatedSupplier.ContactPhone = this.contactPhoneTxt.Text;
                updatedSupplier.ContactEmail = this.contactEmailTxt.Text;
                updatedSupplier.Note = this.supplierNoteTxt.Text;

                if(await service.PutAsJsonAsync<Supplier>("supplier\\" + updatedSupplier.SupplierId, updatedSupplier))
                {
                    Selected = updatedSupplier;
                    DisplaySupplierDetails();
                    this.supplierIdTxt.IsEnabled = true;
                    EnableButtons("found");
                    var messageDialog = new MessageDialog("Supplier has been updated.");
                    await messageDialog.ShowAsync();
                }
                else
                {
                    var messageDialog = new MessageDialog("Error. There was a problem updating existing Supplier");
                }
            }
        }

        private void cancelBtn_Click(object sender, RoutedEventArgs e)
        {
            if(Selected == null)
            {
                this.supplierIdTxt.IsEnabled = true;
                ClearSupplierDetails();
                EnableFields(false);
                EnableButtons("pageLoad");
            }
            else
            {
                DisplaySupplierDetails();
                this.supplierIdTxt.IsEnabled = true;
                EnableButtons("found");
            }
        }

        private void DisplaySupplierDetails()
        {
            this.supplierNameTxt.Text = Selected.Name;
            this.supplierPhoneTxt.Text = Selected.Phone;
            this.supplierEmailTxt.Text = Selected.Email;
            this.supplierWebsiteTxt.Text = Selected.Website;
            this.contactFirstNameTxt.Text = Selected.ContactFirstName;
            this.contactLastNameTxt.Text = Selected.ContactLastName;
            this.contactPhoneTxt.Text = Selected.ContactPhone;
            this.contactEmailTxt.Text = Selected.ContactEmail;
            this.supplierNoteTxt.Text = Selected.Note;
            EnableFields(false);
        }

        private void ClearSupplierDetails()
        {
            this.supplierNameTxt.Text = "";
            this.supplierPhoneTxt.Text = "";
            this.supplierEmailTxt.Text = "";
            this.supplierWebsiteTxt.Text = "";
            this.contactFirstNameTxt.Text = "";
            this.contactLastNameTxt.Text = "";
            this.contactPhoneTxt.Text = "";
            this.contactEmailTxt.Text = "";
            this.supplierNoteTxt.Text = "";
            EnableFields(false);
        }

        private void UpdateSupplierDetails()
        {
            Selected.Name = this.supplierNameTxt.Text;
            Selected.Phone = this.supplierNameTxt.Text;
            Selected.Email = this.supplierEmailTxt.Text;
            Selected.Website = this.supplierWebsiteTxt.Text;
            Selected.ContactFirstName = this.contactFirstNameTxt.Text;
            Selected.ContactLastName = this.contactLastNameTxt.Text;
            Selected.ContactPhone = this.contactPhoneTxt.Text;
            Selected.ContactEmail = this.contactEmailTxt.Text;
            Selected.Note = this.supplierNoteTxt.Text;
        }

        private void EnableFields(bool enabled = true)
        {
            this.supplierNameTxt.IsEnabled = enabled;
            this.supplierPhoneTxt.IsEnabled = enabled;
            this.supplierEmailTxt.IsEnabled = enabled;
            this.supplierWebsiteTxt.IsEnabled = enabled;
            this.contactFirstNameTxt.IsEnabled = enabled;
            this.contactLastNameTxt.IsEnabled = enabled;
            this.contactPhoneTxt.IsEnabled = enabled;
            this.contactEmailTxt.IsEnabled = enabled;
            this.supplierNoteTxt.IsEnabled = enabled;
        }

        private void EnableButtons(string supplier)
        {
            switch (supplier)
            {
                case "pageLoad":
                    this.deleteBtn.IsEnabled = false;
                    this.editBtn.IsEnabled = false;
                    this.saveBtn.IsEnabled = false;
                    this.cancelBtn.IsEnabled = false;
                    this.findBtn.IsEnabled = true;
                    this.addBtn.IsEnabled = true;
                    break;

                case "editing":
                case "adding":
                    this.deleteBtn.IsEnabled = false;
                    this.editBtn.IsEnabled = false;
                    this.addBtn.IsEnabled = false;
                    this.findBtn.IsEnabled = false;
                    this.saveBtn.IsEnabled = true;
                    this.cancelBtn.IsEnabled = true;
                    break;

                case "found":
                    this.saveBtn.IsEnabled = false;
                    this.cancelBtn.IsEnabled = false;
                    this.deleteBtn.IsEnabled = true;
                    this.editBtn.IsEnabled = true;
                    this.addBtn.IsEnabled = true;
                    this.findBtn.IsEnabled = true;
                    break;
            }
        }
    }
}
