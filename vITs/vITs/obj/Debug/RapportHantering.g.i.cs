﻿#pragma checksum "..\..\RapportHantering.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D425C6452C082BCCA7DC93FAFA67D102"
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
        
        
        #line 20 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpStartDate;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpEndDate;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbCountryDeparture;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbCountryArrival;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblDeparture;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblArrival;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblDateTrip;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblVacation;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpVacationEnd;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpVacationStart;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblPrepay;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbPrepaySum;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblMotivation;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbMotivation;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSend;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddBreak;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lbVacations;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbKostnTyp;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblKostnadTyp;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbCostNotes;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblCostNotes;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbPickTripExpensesTab;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbOwnReports;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGetOwnReports;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnShowOwnReports;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbSearchAnstIdDenied;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblSearchAnstIdDenied;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbReportsDenied;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnShowReportsDenied;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGetReportsDenied;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblSearchAnstIdApproved;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbSearchAnstIdApproved;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGetReportsApproved;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\RapportHantering.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbReportsApproved;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\RapportHantering.xaml"
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
            this.dpStartDate = ((System.Windows.Controls.DatePicker)(target));
            
            #line 20 "..\..\RapportHantering.xaml"
            this.dpStartDate.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.dpStartDate_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dpEndDate = ((System.Windows.Controls.DatePicker)(target));
            
            #line 21 "..\..\RapportHantering.xaml"
            this.dpEndDate.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.dpEndDate_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cbCountryDeparture = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.cbCountryArrival = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.lblDeparture = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.lblArrival = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.lblDateTrip = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.lblVacation = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.dpVacationEnd = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 10:
            this.dpVacationStart = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 11:
            this.lblPrepay = ((System.Windows.Controls.Label)(target));
            return;
            case 12:
            this.tbPrepaySum = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            this.lblMotivation = ((System.Windows.Controls.Label)(target));
            return;
            case 14:
            this.tbMotivation = ((System.Windows.Controls.TextBox)(target));
            return;
            case 15:
            this.btnSend = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\RapportHantering.xaml"
            this.btnSend.Click += new System.Windows.RoutedEventHandler(this.btnSend_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            this.btnAddBreak = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\RapportHantering.xaml"
            this.btnAddBreak.Click += new System.Windows.RoutedEventHandler(this.btnAddBreak_Click);
            
            #line default
            #line hidden
            return;
            case 17:
            this.lbVacations = ((System.Windows.Controls.ListView)(target));
            return;
            case 18:
            this.cbKostnTyp = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 19:
            this.lblKostnadTyp = ((System.Windows.Controls.Label)(target));
            return;
            case 20:
            this.tbCostNotes = ((System.Windows.Controls.TextBox)(target));
            return;
            case 21:
            this.lblCostNotes = ((System.Windows.Controls.Label)(target));
            return;
            case 22:
            this.cbPickTripExpensesTab = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 23:
            this.lbOwnReports = ((System.Windows.Controls.ListBox)(target));
            return;
            case 24:
            this.btnGetOwnReports = ((System.Windows.Controls.Button)(target));
            return;
            case 25:
            this.btnShowOwnReports = ((System.Windows.Controls.Button)(target));
            return;
            case 26:
            this.tbSearchAnstIdDenied = ((System.Windows.Controls.TextBox)(target));
            return;
            case 27:
            this.lblSearchAnstIdDenied = ((System.Windows.Controls.Label)(target));
            return;
            case 28:
            this.lbReportsDenied = ((System.Windows.Controls.ListBox)(target));
            return;
            case 29:
            this.btnShowReportsDenied = ((System.Windows.Controls.Button)(target));
            return;
            case 30:
            this.btnGetReportsDenied = ((System.Windows.Controls.Button)(target));
            return;
            case 31:
            this.lblSearchAnstIdApproved = ((System.Windows.Controls.Label)(target));
            return;
            case 32:
            this.tbSearchAnstIdApproved = ((System.Windows.Controls.TextBox)(target));
            return;
            case 33:
            this.btnGetReportsApproved = ((System.Windows.Controls.Button)(target));
            return;
            case 34:
            this.lbReportsApproved = ((System.Windows.Controls.ListBox)(target));
            return;
            case 35:
            this.btnShowReportsApproved = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

