﻿#pragma checksum "C:\Users\Christian\Desktop\Fall Term 2020\CS234N - Advanced C#\BITS\fall-term-project\bitsHomePageUWP\SupplierPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4B8F02535999FDB21BE2282529106975"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace bitsHomePageUWP
{
    partial class SupplierPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_TextBox_Text(global::Windows.UI.Xaml.Controls.TextBox obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class SupplierPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ISupplierPage_Bindings
        {
            private global::bitsHomePageUWP.SupplierPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.TextBox obj7;
            private global::Windows.UI.Xaml.Controls.TextBox obj8;
            private global::Windows.UI.Xaml.Controls.TextBox obj9;
            private global::Windows.UI.Xaml.Controls.TextBox obj10;
            private global::Windows.UI.Xaml.Controls.TextBox obj11;
            private global::Windows.UI.Xaml.Controls.TextBox obj12;
            private global::Windows.UI.Xaml.Controls.TextBox obj13;
            private global::Windows.UI.Xaml.Controls.TextBox obj14;
            private global::Windows.UI.Xaml.Controls.TextBox obj15;
            private global::Windows.UI.Xaml.Controls.TextBox obj16;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj7TextDisabled = false;
            private static bool isobj8TextDisabled = false;
            private static bool isobj9TextDisabled = false;
            private static bool isobj10TextDisabled = false;
            private static bool isobj11TextDisabled = false;
            private static bool isobj12TextDisabled = false;
            private static bool isobj13TextDisabled = false;
            private static bool isobj14TextDisabled = false;
            private static bool isobj15TextDisabled = false;
            private static bool isobj16TextDisabled = false;

            public SupplierPage_obj1_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 88 && columnNumber == 26)
                {
                    isobj7TextDisabled = true;
                }
                else if (lineNumber == 83 && columnNumber == 26)
                {
                    isobj8TextDisabled = true;
                }
                else if (lineNumber == 78 && columnNumber == 26)
                {
                    isobj9TextDisabled = true;
                }
                else if (lineNumber == 72 && columnNumber == 26)
                {
                    isobj10TextDisabled = true;
                }
                else if (lineNumber == 67 && columnNumber == 26)
                {
                    isobj11TextDisabled = true;
                }
                else if (lineNumber == 57 && columnNumber == 26)
                {
                    isobj12TextDisabled = true;
                }
                else if (lineNumber == 51 && columnNumber == 26)
                {
                    isobj13TextDisabled = true;
                }
                else if (lineNumber == 46 && columnNumber == 26)
                {
                    isobj14TextDisabled = true;
                }
                else if (lineNumber == 41 && columnNumber == 26)
                {
                    isobj15TextDisabled = true;
                }
                else if (lineNumber == 36 && columnNumber == 26)
                {
                    isobj16TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 7: // SupplierPage.xaml line 87
                        this.obj7 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        break;
                    case 8: // SupplierPage.xaml line 82
                        this.obj8 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        break;
                    case 9: // SupplierPage.xaml line 77
                        this.obj9 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        break;
                    case 10: // SupplierPage.xaml line 71
                        this.obj10 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        break;
                    case 11: // SupplierPage.xaml line 66
                        this.obj11 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        break;
                    case 12: // SupplierPage.xaml line 56
                        this.obj12 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        break;
                    case 13: // SupplierPage.xaml line 50
                        this.obj13 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        break;
                    case 14: // SupplierPage.xaml line 45
                        this.obj14 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        break;
                    case 15: // SupplierPage.xaml line 40
                        this.obj15 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        break;
                    case 16: // SupplierPage.xaml line 35
                        this.obj16 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // ISupplierPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::bitsHomePageUWP.SupplierPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::bitsHomePageUWP.SupplierPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Selected(obj.Selected, phase);
                    }
                }
            }
            private void Update_Selected(global::bitsHomePageUWP.Models.Supplier obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Selected_Note(obj.Note, phase);
                        this.Update_Selected_ContactEmail(obj.ContactEmail, phase);
                        this.Update_Selected_ContactPhone(obj.ContactPhone, phase);
                        this.Update_Selected_ContactLastName(obj.ContactLastName, phase);
                        this.Update_Selected_ContactFirstName(obj.ContactFirstName, phase);
                        this.Update_Selected_Website(obj.Website, phase);
                        this.Update_Selected_Email(obj.Email, phase);
                        this.Update_Selected_Phone(obj.Phone, phase);
                        this.Update_Selected_Name(obj.Name, phase);
                        this.Update_Selected_SupplierId(obj.SupplierId, phase);
                    }
                }
            }
            private void Update_Selected_Note(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // SupplierPage.xaml line 87
                    if (!isobj7TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj7, obj, null);
                    }
                }
            }
            private void Update_Selected_ContactEmail(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // SupplierPage.xaml line 82
                    if (!isobj8TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj8, obj, null);
                    }
                }
            }
            private void Update_Selected_ContactPhone(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // SupplierPage.xaml line 77
                    if (!isobj9TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj9, obj, null);
                    }
                }
            }
            private void Update_Selected_ContactLastName(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // SupplierPage.xaml line 71
                    if (!isobj10TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj10, obj, null);
                    }
                }
            }
            private void Update_Selected_ContactFirstName(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // SupplierPage.xaml line 66
                    if (!isobj11TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj11, obj, null);
                    }
                }
            }
            private void Update_Selected_Website(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // SupplierPage.xaml line 56
                    if (!isobj12TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj12, obj, null);
                    }
                }
            }
            private void Update_Selected_Email(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // SupplierPage.xaml line 50
                    if (!isobj13TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj13, obj, null);
                    }
                }
            }
            private void Update_Selected_Phone(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // SupplierPage.xaml line 45
                    if (!isobj14TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj14, obj, null);
                    }
                }
            }
            private void Update_Selected_Name(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // SupplierPage.xaml line 40
                    if (!isobj15TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj15, obj, null);
                    }
                }
            }
            private void Update_Selected_SupplierId(global::System.Int32 obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // SupplierPage.xaml line 35
                    if (!isobj16TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj16, obj.ToString(), null);
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1: // SupplierPage.xaml line 1
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)(target);
                    ((global::Windows.UI.Xaml.Controls.Page)element1).Loaded += this.Page_Loaded;
                }
                break;
            case 2: // SupplierPage.xaml line 100
                {
                    this.deleteBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.deleteBtn).Click += this.deleteBtn_Click;
                }
                break;
            case 3: // SupplierPage.xaml line 101
                {
                    this.editBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.editBtn).Click += this.editBtn_Click;
                }
                break;
            case 4: // SupplierPage.xaml line 102
                {
                    this.addBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.addBtn).Click += this.addBtn_Click;
                }
                break;
            case 5: // SupplierPage.xaml line 103
                {
                    this.saveBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.saveBtn).Click += this.saveBtn_Click;
                }
                break;
            case 6: // SupplierPage.xaml line 104
                {
                    this.cancelBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.cancelBtn).Click += this.cancelBtn_Click;
                }
                break;
            case 7: // SupplierPage.xaml line 87
                {
                    this.supplierNoteTxt = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8: // SupplierPage.xaml line 82
                {
                    this.contactEmailTxt = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 9: // SupplierPage.xaml line 77
                {
                    this.contactPhoneTxt = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 10: // SupplierPage.xaml line 71
                {
                    this.contactLastNameTxt = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 11: // SupplierPage.xaml line 66
                {
                    this.contactFirstNameTxt = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 12: // SupplierPage.xaml line 56
                {
                    this.supplierWebsiteTxt = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 13: // SupplierPage.xaml line 50
                {
                    this.supplierEmailTxt = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 14: // SupplierPage.xaml line 45
                {
                    this.supplierPhoneTxt = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 15: // SupplierPage.xaml line 40
                {
                    this.supplierNameTxt = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 16: // SupplierPage.xaml line 35
                {
                    this.supplierIdTxt = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 17: // SupplierPage.xaml line 30
                {
                    this.supplierrIdTxt = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 18: // SupplierPage.xaml line 31
                {
                    this.findBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.findBtn).Click += this.findBtn_Click;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // SupplierPage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    SupplierPage_obj1_Bindings bindings = new SupplierPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

