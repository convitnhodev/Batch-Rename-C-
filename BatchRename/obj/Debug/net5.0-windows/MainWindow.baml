   M S B A M L   `   `   `  ????F  BBatchRename, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:BatchRenameBatchRename  5   	   M IFluent, Version=8.0.0.0, Culture=neutral, PublicKeyToken=3e436e32a8c5546f/$clr-namespace:Fluent;assembly=FluentFluent 5   	       BatchRename.MainWindow   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:BatchRename     5   	   7Fluent$clr-namespace:Fluent;assembly=Fluent     5   	   -   5          ? Title$  Batch Rename??5	   	   $	??500??6   $	??800??6+   .??5
      ?  ? ColumnDefinitions 5   
   ?? 5      $??* ?6    ? RowDefinitions 5   
   ?? 5      $
??Auto ?6   ?? 5      $??* ?6   .+?5   
     Fluent.Ribbon  $??0??6      Menu 5        Fluent.Backstage  5        Fluent.RibbonControl   Header$
 File??6#      Content. 5         Fluent.BackstageTabControl  .@?5        Fluent.BackstageTabItem  -   5           Header$	 New??5   2   .??5      ?? $??New File??6%   $??80??68   $??35??6C   6R   5      5      5         Tabs. 5"        Fluent.RibbonTabItem     Header$
 Home??6#   	   Groups.	 5#        Fluent.RibbonGroupBox  $??Options??6(   .@?5$        Fluent.Button  -   5        $??btnReset??5$   3   
   Header$
 Reset??6$      	LargeIcon 5%      ?? 5&      $??/icons/reset.png??6$    ?? BitmapScalingMode$ HighQuality=?6>   6n   5(        5)      -   5        $??btnHelp??5)   2   $

 Help??6$    5*      ?? 5+      $??/icons/help.png??6$   $ HighQuality=?6=   6m   5-        5.      -   5        $??btnAbout??5.   3   $
 About??6$    5/      ?? 50      $??/icons/about.png??6$   $ HighQuality=?6>   6n   52        53      -   5        $??btnStart??53   3   $
 Start??6$    54      ?? 55      $??/icons/start.png??6$   $ HighQuality=?6>   6n   57      58        5:      $??Method??6(   .@?5;      ?? $??Method??6   6/   ?? 5<      -   5        $??methodComboBox??5<   ,   $	??125??6    ??5=      ?? 5>      .R?5?   "   ?? ??6,   ?? *name+5@      5B        5C      -   5        $??btnAddMethod??5C   8   $
 
Add Method??6$    5D      ?? 5E      $??/icons/add.png??6$   $ HighQuality=?6<   6l   5G        5H      -	   5        $??btnClearAllMethod??5H   >   $
 Clear All Method??6$    5I      ?? 5J      $??/icons/deleteMethod.png??6$   $ HighQuality=?6E   6u   5L        5M      -
   5        $??btnClearAllFileFolder??5M   ?   $
 Clear File/Folder??6$    5N      ?? 5O      $??/icons/clearAllMethod.png??6$   $ HighQuality=?6G   6w   5Q      5R        5T      $??Preset??6(   .@?5U        -   5        $??
LoadPreset??5U   9   $
 Load Preset??6$    5V      ?? 5W      $??/icons/LoadPreset.png??6$   $ HighQuality=?6D   5Y        5Z      -   5        $??
SavePreset??5Z   :   $
 Save Preset??6$    5[      ?? 5\      $??/icons/SavePreset.png??6$   $ HighQuality=?6D   5^      5`        5b      $??
XML Preset??6(   .@?5c        -   5        $??LoadXMLPreset??5c   =   $
 Load XML Preset??6$    5d      ?? 5e      $??/icons/LoadPreset.png??6$   $ HighQuality=?6D   5g        5h      -   5        $??SaveXMLPreset??5h   <   $
 Save XML Rule??6$    5i      ?? 5j      $??/icons/SavePreset.png??6$   $ HighQuality=?6D   5l      5n      5o      5p      ? 5r   
   $??1??6   $??0 0 0 0q?6    5s      ?? 5t      $	??300 ?6#   ?? 5u      $??* ?6#   .+?5w      ?? -   5        $??methodListBox??5w      $??0??6+   $??Disabled=?6;    ? ContextMenu 5x      ?? 5y      .@?5z      m? -   5        $??btnEditMethod??5z   1   $
??Edit??6#   6F   m? 5{      -   5        $??btnDeleteMethod??5{   3   $??Delete??6#   6J   5|      ??5~      ?? 5      .R?5?      ]? .+?5?      ?? $	??Top=?6(   $??15(?6S   $
??Wrap=?6a   $??Medium"?6u   $??Italic$?6?   ??6=   ?? *name+6?   ?? 5?      $	??Top=?6(   $??15(?6[   $
??Wrap=?6i   $??Medium"?6}   $??Italic$?6?   ??6=   ?? *Args.Details+6?   5?      5?      5?      ]? 5?      $??1??6   .+?5?      ?? .@?5?      ?? ??5?      ]? 5?      $
??Left=?6(   .+?5?   "   ?? $??Rename File??6,   6A   5?      .??5?      ]? .+?5?      `? $	??Top=?6*   .?5?   "   c? .@?5?   &   ]? .+?5?   *   ?? -   5         ??Name$ AddFileButtons??5?   1   $??5 0 5 0q?6J   .??5?   .   ??  ?? Orientation$ 
Horizontal=?69   .+?5?   2   ?? $??/icons/add.png??68   $??16??6P   $??16??6\   $ HighQuality=?6g   $??0 0 2 0q?6?   ?? 5?   2   $	??Add??6<   5?   /   5?   +   ?? 5?   *   -   5        $ PreviewFileButtons??5?   1   $??15 0 5 0q?6N   .??5?   .   ?? $ 
Horizontal=?69   .+?5?   2   ?? $??/icons/preview.png??68   $??16??6T   $??16??6`   $ HighQuality=?6k   $??0 0 2 0q?6?   ?? 5?   2   $??Preview??6<   5?   /   5?   +   5?   '   5?   #   5?      ?? 5?      $
??Auto=?6,   $
??auto??6]   .??5?   "   &	   System.Windows.Controls.DataGrid	  -   5        $??FileTab??5?   +   
??????  	  GridLinesVisibility$	 All=?6S    	  
IsReadOnly$
 True??6m    J? 	AllowDrop$
 True??6    	  Columns 5?   &   0
  *System.Windows.Controls.DataGridTextColumn
  5?   *   ,  &System.Windows.Controls.DataGridColumn   Header$ Filename??6=      Width5  /System.Windows.Controls.DataGridLengthConverter$ 5* 6l      SortDirection 	Ascending6w   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6O   ?? *
Filename+6w   
  5?   *   $ Preview??6=   $ 5* 6n    6N   ?? *PreviewFile+6n   
  5?   *   $ New Filename??6=   $ 5* 6s    6S   ?? *Newfilename+6s   
  5?   *   $
 Path??6=   $ 5* 6d    6K   ?? *Path+6d   
  5?   *   $ Error??6=   $ 2* 6f    6L   ?? *Error+6f   5?   #   5?      5?      5?      ?? 5?      ??5?      ]? 5?      $
??Left=?6(   .+?5?   "   ?? $??Rename Folder??6,   6C   5?      .??5?      ]? .+?5?      `? $	??Top=?6*   .?5?   "   c? .@?5?   &   ]? .+?5?   *   ?? -   5        $ AddFolderButtons??5?   1   $??5 0 5 0q?6L   .??5?   .   ?? $ 
Horizontal=?69   .+?5?   2   ?? $??/icons/add.png??68   $??16??6P   $??16??6\   $ HighQuality=?6g   $??0 0 2 0q?6?   ?? 5?   2   $	??Add??6<   5?   /   5?   +   ?? 5?   *   -   5        $ PreviewFolderButtons??5?   1   $??15 0 5 0q?6P   .??5?   .   ?? $ 
Horizontal=?69   .+?5?   2   ?? $??/icons/preview.png??68   $??16??6T   $??16??6`   $ HighQuality=?6k   $??0 0 2 0q?6?   ?? 5?   2   $??Preview??6<   5?   /   5?   +   5?   '   5?   #   5?      ?? 5?      $
??Auto=?6,   $
??auto??6]   .??5?   "   	  -   5        $??	FolderTab??5?   +   
?????? $	 All=?6U   $
 True??6o   $
 True??6?    5?   &   
  5?   *   $ 
Foldername??6=   $ 5* 6p    	Ascending6{    6Q   ?? *
Foldername+6{   
  5?   *   $ Preview??6=   $ 5* 6p    6N   ?? *PreviewFolder+6p   
  5?   *   $ New Foldername??6=   $ 5* 6s    6U   ?? *	Newfolder+6s   
  5?   *   $
 Path??6=   $ 5* 6d    6K   ?? *Path+6d   
  5?   *   $ Error??6=   $ 2* 6f    6L   ?? *Error+6f   5?   #   5?      5?      5?      ?? 5?      ??5?      ]? 5?      $
??Left=?6(   .+?5?   "   ?? $ ??Rename List File In Folder??6,   6P   5?      .??5?      ]? .+?5?      `? $	??Top=?6*   .?5?   "   c? .@?5?   &   ]? .+?5?   *   ?? -   5        $  AddListFileInFolderButtons??5?   1   $??5 0 5 0q?6V   .??5?   .   ?? $ 
Horizontal=?69   .+?5?   2   ?? $??/icons/add.png??68   $??16??6P   $??16??6\   $ HighQuality=?6g   $??0 0 2 0q?6?   ?? 5?   2   $	??Add??6<   5?   /   5?   +   ?? 5?   *   -   5        $ PreviewListFileButtons??5?   1   $??15 0 5 0q?6R   .??5?   .   ?? $ 
Horizontal=?69   .+?5?   2   ?? $??/icons/preview.png??68   $??16??6T   $??16??6`   $ HighQuality=?6k   $??0 0 2 0q?6?   ?? 5?   2   $??Preview??6<   5?   /   5?   +   5?   '   5?   #   5?      ?? 5?      $
??Auto=?6,   $
??auto??6]   .??5?   "   	  -   5        $??FileInFolderTab??5?   +   
?????? $	 All=?6[   $
 True??6u   $
 True??6?    5?   &   
  5?   *   $ Filename??6=   $ 5* 6l    	Ascending6w    6O   ?? *
Filename+6w   
  5?   *   $ Preview??6=   $ 5* 6n    6N   ?? *PreviewFile+6n   
  5?   *   $ New Filename??6=   $ 5* 6s    6S   ?? *Newfilename+6s   
  5?   *   $
 Path??6=   $ 5* 6d    6K   ?? *Path+6d   
  5?   *   $ Error??6=   $ 2* 6f    6L   ?? *Error+6f   5?   #   5?      5?      5?      5?      5     5     5     5     