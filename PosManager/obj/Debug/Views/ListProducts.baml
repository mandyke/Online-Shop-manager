   M S B A M L   `   `   `  ����E  APosManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:PosManager.ViewsPosManager.Views  5      #    PosManager.Views.ListProducts   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:PosManager.Views     5      
�������.��5	      �   � RowDefinitions  5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6   .+�5   
   �� $��0��6   $��1��6"   $��36(�62   $��List of Products��5      $��3��6,   $��0,0,0,10q�5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ AddProductGrid��5      $��1��6,   $��5��6=   $��20��6J   $��6��6X   $��3��6l      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn   Header$ 
Product ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *ID+  5!      $ Product Name��6%    6;   �� *ProductName+  5"      $ Product Categories��6%    6A   �� *CategoriesName+  5#      $ Amount��6%    65   �� *Amount+  5$      $ Available Quantity��6%    6A   �� *AvailableQuantity+4  .System.Windows.Controls.DataGridTemplateColumn  5%      $
 Edit��6)      CellTemplate 5&      �� 5'      .R�5(      �� $
��Edit��6%   5)      5+        5,      $ Delete��6)    5-      �� 5.      .R�5/      �� -   5        $��Delete��5/   %   66   50      52         RowDetailsTemplate 54      �� 55      57      59      5;      5<      