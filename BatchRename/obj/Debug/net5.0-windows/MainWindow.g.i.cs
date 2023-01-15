﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9C21377B6B57F750C079AA993BE17684AE195A69"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BatchRename;
using Fluent;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace BatchRename {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : Fluent.RibbonWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button btnReset;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button btnHelp;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button btnAbout;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button btnStart;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox methodComboBox;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button btnAddMethod;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button btnClearAllMethod;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button btnClearAllFileFolder;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button LoadPreset;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button SavePreset;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button LoadXMLPreset;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button SaveXMLPreset;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox methodListBox;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem btnEditMethod;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem btnDeleteMethod;
        
        #line default
        #line hidden
        
        
        #line 148 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddFileButtons;
        
        #line default
        #line hidden
        
        
        #line 154 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PreviewFileButtons;
        
        #line default
        #line hidden
        
        
        #line 165 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid FileTab;
        
        #line default
        #line hidden
        
        
        #line 188 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddFolderButtons;
        
        #line default
        #line hidden
        
        
        #line 194 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PreviewFolderButtons;
        
        #line default
        #line hidden
        
        
        #line 204 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid FolderTab;
        
        #line default
        #line hidden
        
        
        #line 227 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddListFileInFolderButtons;
        
        #line default
        #line hidden
        
        
        #line 233 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PreviewListFileButtons;
        
        #line default
        #line hidden
        
        
        #line 243 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid FileInFolderTab;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/BatchRename;V1.0.0.0;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 9 "..\..\..\MainWindow.xaml"
            ((BatchRename.MainWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.RibbonWindow_Loaded);
            
            #line default
            #line hidden
            
            #line 9 "..\..\..\MainWindow.xaml"
            ((BatchRename.MainWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.RibbonWindow_Closing);
            
            #line default
            #line hidden
            
            #line 9 "..\..\..\MainWindow.xaml"
            ((BatchRename.MainWindow)(target)).SourceInitialized += new System.EventHandler(this.RibbonWindow_SourceInitialized);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 24 "..\..\..\MainWindow.xaml"
            ((Fluent.BackstageTabItem)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.NewFile_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnReset = ((Fluent.Button)(target));
            
            #line 36 "..\..\..\MainWindow.xaml"
            this.btnReset.Click += new System.Windows.RoutedEventHandler(this.btnReset_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnHelp = ((Fluent.Button)(target));
            
            #line 41 "..\..\..\MainWindow.xaml"
            this.btnHelp.Click += new System.Windows.RoutedEventHandler(this.btnHelp_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnAbout = ((Fluent.Button)(target));
            
            #line 46 "..\..\..\MainWindow.xaml"
            this.btnAbout.Click += new System.Windows.RoutedEventHandler(this.btnAbout_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnStart = ((Fluent.Button)(target));
            
            #line 51 "..\..\..\MainWindow.xaml"
            this.btnStart.Click += new System.Windows.RoutedEventHandler(this.btnStart_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.methodComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.btnAddMethod = ((Fluent.Button)(target));
            
            #line 67 "..\..\..\MainWindow.xaml"
            this.btnAddMethod.Click += new System.Windows.RoutedEventHandler(this.btnAddMethod_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnClearAllMethod = ((Fluent.Button)(target));
            
            #line 72 "..\..\..\MainWindow.xaml"
            this.btnClearAllMethod.Click += new System.Windows.RoutedEventHandler(this.btnClearAllMethod_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnClearAllFileFolder = ((Fluent.Button)(target));
            
            #line 77 "..\..\..\MainWindow.xaml"
            this.btnClearAllFileFolder.Click += new System.Windows.RoutedEventHandler(this.btnClearAllFileFolder_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.LoadPreset = ((Fluent.Button)(target));
            
            #line 85 "..\..\..\MainWindow.xaml"
            this.LoadPreset.Click += new System.Windows.RoutedEventHandler(this.LoadPreset_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.SavePreset = ((Fluent.Button)(target));
            
            #line 90 "..\..\..\MainWindow.xaml"
            this.SavePreset.Click += new System.Windows.RoutedEventHandler(this.SavePreset_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.LoadXMLPreset = ((Fluent.Button)(target));
            
            #line 99 "..\..\..\MainWindow.xaml"
            this.LoadXMLPreset.Click += new System.Windows.RoutedEventHandler(this.LoadXMLPreset_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.SaveXMLPreset = ((Fluent.Button)(target));
            
            #line 104 "..\..\..\MainWindow.xaml"
            this.SaveXMLPreset.Click += new System.Windows.RoutedEventHandler(this.SaveXMLPreset_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.methodListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 16:
            this.btnEditMethod = ((System.Windows.Controls.MenuItem)(target));
            
            #line 122 "..\..\..\MainWindow.xaml"
            this.btnEditMethod.Click += new System.Windows.RoutedEventHandler(this.btnEditMethod_Click);
            
            #line default
            #line hidden
            return;
            case 17:
            this.btnDeleteMethod = ((System.Windows.Controls.MenuItem)(target));
            
            #line 123 "..\..\..\MainWindow.xaml"
            this.btnDeleteMethod.Click += new System.Windows.RoutedEventHandler(this.btnDeleteMethod_Click);
            
            #line default
            #line hidden
            return;
            case 18:
            this.AddFileButtons = ((System.Windows.Controls.Button)(target));
            
            #line 148 "..\..\..\MainWindow.xaml"
            this.AddFileButtons.Click += new System.Windows.RoutedEventHandler(this.AddFileButtons_Click);
            
            #line default
            #line hidden
            return;
            case 19:
            this.PreviewFileButtons = ((System.Windows.Controls.Button)(target));
            
            #line 154 "..\..\..\MainWindow.xaml"
            this.PreviewFileButtons.Click += new System.Windows.RoutedEventHandler(this.PreviewFileButtons_Click);
            
            #line default
            #line hidden
            return;
            case 20:
            this.FileTab = ((System.Windows.Controls.DataGrid)(target));
            
            #line 165 "..\..\..\MainWindow.xaml"
            this.FileTab.DragEnter += new System.Windows.DragEventHandler(this.FileTab_DragEnter);
            
            #line default
            #line hidden
            
            #line 165 "..\..\..\MainWindow.xaml"
            this.FileTab.AddHandler(System.Windows.DragDrop.DropEvent, new System.Windows.DragEventHandler(this.FileTab_Drop));
            
            #line default
            #line hidden
            return;
            case 21:
            this.AddFolderButtons = ((System.Windows.Controls.Button)(target));
            
            #line 188 "..\..\..\MainWindow.xaml"
            this.AddFolderButtons.Click += new System.Windows.RoutedEventHandler(this.AddFolderButtons_Click);
            
            #line default
            #line hidden
            return;
            case 22:
            this.PreviewFolderButtons = ((System.Windows.Controls.Button)(target));
            
            #line 194 "..\..\..\MainWindow.xaml"
            this.PreviewFolderButtons.Click += new System.Windows.RoutedEventHandler(this.PreviewFolderButtons_Click);
            
            #line default
            #line hidden
            return;
            case 23:
            this.FolderTab = ((System.Windows.Controls.DataGrid)(target));
            
            #line 204 "..\..\..\MainWindow.xaml"
            this.FolderTab.DragEnter += new System.Windows.DragEventHandler(this.FolderTab_DragEnter);
            
            #line default
            #line hidden
            
            #line 204 "..\..\..\MainWindow.xaml"
            this.FolderTab.AddHandler(System.Windows.DragDrop.DropEvent, new System.Windows.DragEventHandler(this.FolderTab_Drop));
            
            #line default
            #line hidden
            return;
            case 24:
            this.AddListFileInFolderButtons = ((System.Windows.Controls.Button)(target));
            
            #line 227 "..\..\..\MainWindow.xaml"
            this.AddListFileInFolderButtons.Click += new System.Windows.RoutedEventHandler(this.AddListFileInFolderButtons_Click);
            
            #line default
            #line hidden
            return;
            case 25:
            this.PreviewListFileButtons = ((System.Windows.Controls.Button)(target));
            
            #line 233 "..\..\..\MainWindow.xaml"
            this.PreviewListFileButtons.Click += new System.Windows.RoutedEventHandler(this.PreviewListFileButtons_Click);
            
            #line default
            #line hidden
            return;
            case 26:
            this.FileInFolderTab = ((System.Windows.Controls.DataGrid)(target));
            
            #line 243 "..\..\..\MainWindow.xaml"
            this.FileInFolderTab.DragEnter += new System.Windows.DragEventHandler(this.FileInFolderTab_DragEnter);
            
            #line default
            #line hidden
            
            #line 243 "..\..\..\MainWindow.xaml"
            this.FileInFolderTab.AddHandler(System.Windows.DragDrop.DropEvent, new System.Windows.DragEventHandler(this.FileInFolderTab_Drop));
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

