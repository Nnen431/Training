   M S B A M L   `   `   `  ����  Test123    Test123.ManagerPg   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        N� Title$  	ManagerPg��5      .��5
      �  � RowDefinitions 5   
   �� 5      $��10 �6   �� 5      $��30 �6   �� 5      $��35 �6   �� 5      $��30 �6   �� 5      $��35 �6   �� 5      $��60 �6   �� 5      $��* �6   .+�5   
   �� -   5        $��UserInfoTextBlock��5      $��16(�6-   $��10q�6;   �� 5   
   $��1��6   $��Center=�6"    �� Orientation$ 
Horizontal=�6?   .+�5      �� $��
Book Name:��6   �� 5      -   5         ��Name$ BookName��5      $	��200��6(   5      �� 5   
   $��2��6   $��Center=�6"   $ 
Horizontal=�6?   .+�5      �� $��Year:��6   $��65��6%   �� 5      -   5        $ BookYear��5      $	��200��6(   5      �� 5   
   $��3��6   $��Center=�6"   $ 
Horizontal=�6?   .+�5       �� $��Author:��6   $��65��6'   �� 5!      -   5        $ 
BookAuthor��5!      $	��200��6*   5"      �� 5#   
   -   5        $��Add Book��5#      $��4��6$   $	��200��61   6=   &   System.Windows.Controls.DataGrid  5%   
   -   5        $��	BooksGrid��5%   /      AutoGenerateColumns .  $��7��6@   $	��600��6N   $	��300��6Z      Columns 5&      0  *System.Windows.Controls.DataGridTextColumn  5'      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 200 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Name+6L     5(      $
 Year��6%   $	 100 6U    63   �� *PublishedYear+6U     5)      $ Author��6%   $	 200 6P    65   �� *Author+6P   5+      5,      5-      