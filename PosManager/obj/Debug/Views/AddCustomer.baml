   M S B A M L   `   `   `  ����E  APosManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:PosManager.ViewsPosManager.Views  5      "    PosManager.Views.AddCustomer   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:PosManager.Views     5      
�������.��5	      � .+�5
   
   �   � RowDefinitions  5      �� 5      $��20 �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $��* �6    �� 5      $��20 �6     � ColumnDefinitions 5      �� 5      $��20 �6#   �� 5      $
��auto �6#   �� 5      $
��auto �6#   �� 5      $
��auto �6#   �� 5      $
��auto �6#   �� 5      $
��auto �6#   �� 5      $
��auto �6#   �� 5      $
��auto �6#   �� 5       $��* �6#   �� 5!      $��20 �6#   .+�5$      �� $��Add New Customer��6   $��1��60   $��1��6>   $��36(�6N   $��3��5%      $��0,0,0,10q�5&      
�������6&   �� 5(      $��1��6   $��2��6(   $��
First Name��65   $��0,0,0,10q�6G   �� 5)      -   5         ��Name$ customerFirstName��5)      $��2��61   $��2��6A   $	��150��5*      $��0,0,0,10q�6   �� 5,      $��5��6   $��2��6(   $��	Last Name��65   $��0,0,0,10q�6F   �� 5-      -   5        $ customerLastName��5-      $��6��60   $��2��6@   $	��150��5.      $��0,0,0,10q�6   �� 50      $��3��6   $��3��6(   $��Email��65   $��0,0,0,10q�6B   �� 51      -   5        $ email��51   #   $��3��6   $��4��62   $	��150��6B   $��0 0 0 10q�6N   $
��Left=�6`   �� 53      $��1��6   $��3��6(   $��Phone Number��54      $��0,0,0,10q�6(   �� 56      -   5        $ phoneNumber��56      $��2��6+   $��3��6;   $	��150��57      $��0,0,0,10q�6   �� 5<      -   5         ��Name$ submitButton��5<      $��Submit��6+   $��5��5=      $��4��6!   $��0,0,0,10q�5>      6#   &   System.Windows.Controls.DataGrid  5@      -   5          Name$ AddCustomerGrid��5@      $��1��61   $��5��6B   $��20��6O   $��6��6]   $��3��6q      Columns 5A      0  *System.Windows.Controls.DataGridTextColumn  5B      ,  &System.Windows.Controls.DataGridColumn   Header$ Customer ID��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   �� *
CustomerID+  5C      $ 
First Name��6)    6=   �� *	FirstName+  5D      $ 	Last Name��6)    6<   �� *
LastName+  5E      $ Email��6)    68   �� *Email+  5F      $ Phone Number��6)    6?   �� *PhoneNumber+   RowDetailsTemplate 5H      �� 5I      5K      5M      5N      5P      5Q      