﻿#pragma checksum "..\..\RapportHantering.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4FD4D2AE0E3815AB9CDACCC095040260"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DAL;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace vITs {
    
    
    /// <summary>
    /// RapportHantering
    /// </summary>
    public partial class RapportHantering : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem tab1;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpStartDate;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpEndDate;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbCountryDeparture;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbCountryArrival;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblDeparture;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblArrival;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblDateTrip;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblVacation;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpVacationEnd;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpVacationStart;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblPrepay;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbPrepaySum;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblMotivation;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbMotivation;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSend;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddBreak;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lbVacations;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button anvInstallningar;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbBosses;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem tab2;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbCost;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddVerification;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbKostnTyp;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblKostnadTyp;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbCostNotes;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblCostNotes;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbPickTripExpensesTab;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpExpence;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem tab3;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnShowOwnReports;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvReports;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbFilterAll;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbFilterMonth;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbFilterQuater;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbFilterYear;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem tab4;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbSearchAnstIdDenied;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblSearchAnstIdDenied;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbReportsDenied;
        
        #line default
        #line hidden
        
        
        #line 127 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnShowReportsDenied;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGetReportsDenied;
        
        #line default
        #line hidden
        
        
        #line 133 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnApprove;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDeny;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem tab5;
        
        #line default
        #line hidden
        
        
        #line 152 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblSearchAnstIdApproved;
        
        #line default
        #line hidden
        
        
        #line 153 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbSearchAnstIdApproved;
        
        #line default
        #line hidden
        
        
        #line 154 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGetReportsApproved;
        
        #line default
        #line hidden
        
        
        #line 159 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbReportsApproved;
        
        #line default
        #line hidden
        
        
        #line 160 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnShowReportsApproved;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/vITs;component/rapporthantering.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\RapportHantering.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.tab1 = ((System.Windows.Controls.TabItem)(target));
            return;
            case 2:
            this.dpStartDate = ((System.Windows.Controls.DatePicker)(target));
            
            #line 21 "..\..\RapportHantering.xaml"
            this.dpStartDate.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.dpStartDate_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.dpEndDate = ((System.Windows.Controls.DatePicker)(target));
            
            #line 22 "..\..\RapportHantering.xaml"
            this.dpEndDate.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.dpEndDate_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cbCountryDeparture = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.cbCountryArrival = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.lblDeparture = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.lblArrival = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.lblDateTrip = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.lblVacation = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.dpVacationEnd = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 11:
            this.dpVacationStart = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 12:
            this.lblPrepay = ((System.Windows.Controls.Label)(target));
            return;
            case 13:
            this.tbPrepaySum = ((System.Windows.Controls.TextBox)(target));
            return;
            case 14:
            this.lblMotivation = ((System.Windows.Controls.Label)(target));
            return;
            case 15:
            this.tbMotivation = ((System.Windows.Controls.TextBox)(target));
            return;
            case 16:
            this.btnSend = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\RapportHantering.xaml"
            this.btnSend.Click += new System.Windows.RoutedEventHandler(this.btnSend_Click);
            
            #line default
            #line hidden
            return;
            case 17:
            this.btnAddBreak = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\RapportHantering.xaml"
            this.btnAddBreak.Click += new System.Windows.RoutedEventHandler(this.btnAddBreak_Click);
            
            #line default
            #line hidden
            return;
            case 18:
            this.lbVacations = ((System.Windows.Controls.ListView)(target));
            return;
            case 19:
            this.anvInstallningar = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\RapportHantering.xaml"
            this.anvInstallningar.Click += new System.Windows.RoutedEventHandler(this.anvInstalnningar_Click);
            
            #line default
            #line hidden
            return;
            case 20:
            this.cbBosses = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 21:
            this.tab2 = ((System.Windows.Controls.TabItem)(target));
            return;
            case 22:
            this.tbCost = ((System.Windows.Controls.TextBox)(target));
            return;
            case 23:
            this.btnAddVerification = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\RapportHantering.xaml"
            this.btnAddVerification.Click += new System.Windows.RoutedEventHandler(this.btnAddVerification_Click);
            
            #line default
            #line hidden
            return;
            case 24:
            this.cbKostnTyp = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 25:
            this.lblKostnadTyp = ((System.Windows.Controls.Label)(target));
            return;
            case 26:
            this.tbCostNotes = ((System.Windows.Controls.TextBox)(target));
            return;
            case 27:
            this.lblCostNotes = ((System.Windows.Controls.Label)(target));
            return;
            case 28:
            this.cbPickTripExpensesTab = ((System.Windows.Controls.ComboBox)(target));
            
            #line 81 "..\..\RapportHantering.xaml"
            this.cbPickTripExpensesTab.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbPickTripExpensesTab_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 29:
            this.dpExpence = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 30:
            this.tab3 = ((System.Windows.Controls.TabItem)(target));
            return;
            case 31:
            this.btnShowOwnReports = ((System.Windows.Controls.Button)(target));
            
            #line 92 "..\..\RapportHantering.xaml"
            this.btnShowOwnReports.Click += new System.Windows.RoutedEventHandler(this.btnShowOwnReports_Click);
            
            #line default
            #line hidden
            return;
            case 32:
            
            #line 93 "..\..\RapportHantering.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 33:
            this.lvReports = ((System.Windows.Controls.ListView)(target));
            return;
            case 34:
            this.rbFilterAll = ((System.Windows.Controls.RadioButton)(target));
            
            #line 106 "..\..\RapportHantering.xaml"
            this.rbFilterAll.Checked += new System.Windows.RoutedEventHandler(this.rbFilterAll_Checked);
            
            #line default
            #line hidden
            return;
            case 35:
            this.rbFilterMonth = ((System.Windows.Controls.RadioButton)(target));
            
            #line 107 "..\..\RapportHantering.xaml"
            this.rbFilterMonth.Checked += new System.Windows.RoutedEventHandler(this.rbFilterMonth_Checked);
            
            #line default
            #line hidden
            return;
            case 36:
            this.rbFilterQuater = ((System.Windows.Controls.RadioButton)(target));
            
            #line 108 "..\..\RapportHantering.xaml"
            this.rbFilterQuater.Checked += new System.Windows.RoutedEventHandler(this.rbFilterQuater_Checked);
            
            #line default
            #line hidden
            return;
            case 37:
            this.rbFilterYear = ((System.Windows.Controls.RadioButton)(target));
            
            #line 109 "..\..\RapportHantering.xaml"
            this.rbFilterYear.Checked += new System.Windows.RoutedEventHandler(this.rbFilterYear_Checked);
            
            #line default
            #line hidden
            return;
            case 38:
            this.tab4 = ((System.Windows.Controls.TabItem)(target));
            return;
            case 39:
            this.tbSearchAnstIdDenied = ((System.Windows.Controls.TextBox)(target));
            return;
            case 40:
            this.lblSearchAnstIdDenied = ((System.Windows.Controls.Label)(target));
            return;
            case 41:
            this.lbReportsDenied = ((System.Windows.Controls.ListBox)(target));
            return;
            case 42:
            this.btnShowReportsDenied = ((System.Windows.Controls.Button)(target));
            return;
            case 43:
            this.btnGetReportsDenied = ((System.Windows.Controls.Button)(target));
            return;
            case 44:
            this.btnApprove = ((System.Windows.Controls.Button)(target));
            
            #line 133 "..\..\RapportHantering.xaml"
            this.btnApprove.Click += new System.Windows.RoutedEventHandler(this.btnApprove_Click);
            
            #line default
            #line hidden
            return;
            case 45:
            this.btnDeny = ((System.Windows.Controls.Button)(target));
            
            #line 134 "..\..\RapportHantering.xaml"
            this.btnDeny.Click += new System.Windows.RoutedEventHandler(this.btnDeny_Click);
            
            #line default
            #line hidden
            return;
            case 46:
            this.tab5 = ((System.Windows.Controls.TabItem)(target));
            return;
            case 47:
            this.lblSearchAnstIdApproved = ((System.Windows.Controls.Label)(target));
            return;
            case 48:
            this.tbSearchAnstIdApproved = ((System.Windows.Controls.TextBox)(target));
            return;
            case 49:
            this.btnGetReportsApproved = ((System.Windows.Controls.Button)(target));
            return;
            case 50:
            this.lbReportsApproved = ((System.Windows.Controls.ListBox)(target));
            return;
            case 51:
            this.btnShowReportsApproved = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

