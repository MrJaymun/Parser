   M S B A M L   `   `   `  ����A  =Parser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ParserParser  5   	       Parser.AllThreats   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Parser     5   	     � Title$  
AllThreats��5   	   $	��500��6   $	��950��6)    � WindowStartupLocation$ CenterScreen=�66   $	��500��6[   $	��950��6k   .��5	      �  � RowDefinitions 5
   
   �� 5      6   �� 5      6   �� 5      6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��allInfo��5      $��0��6"   $��0��62   $��3��6@   $��2��6T   "   VerticalScrollBarVisibility$ Disabled=�6e   $	��310��6�   $
��10,0q�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$- 'Идентификатор угрозы��6%      CanUserResize .     Width5  /System.Windows.Controls.DataGridLengthConverter$	 200 6Y   	   
IsReadOnly	 . 1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6w   �� *id+   HeaderStyle 5      �� 5       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6    .�5      ��  �� Property � �� �� Value$ Center=�6K   5      5        5      $+ %Наименование угрозы��6%    .  $ * 6Y   	 . 
 6v   �� *name+ 5      �� 5       "  6    .�5!      ��  � ��$ Center=�6K   5"      5$      5'      � 5)   
   $��0��6   $��2��6    5*      �� 5+      6"   �� 5,      6"   �� 5-      6"   .+�50      �� -   5        $
��prev��50      $��1��6#   $
��10,0q�60   $��Italic$�6P   $
��Bold"�6c   
�������
����  �
����  �.��6�   '%Предыдущая страница52      53      � 54   
   $��1��6   $��2��6    55      �� 56      6"   �� 57      6"   �� 58      6"   .+�5;      �� -   5        $
��back��5;      $��1��6#   $
��10,0q�60   $��Italic$�6Q   $
��Bold"�6d   
�������
����  �
����  �.��6�   Вернуться5=      �� 5>      -   5        $��pager��5>      $��2��6&   $��10,25,10,10q�63   $��Center=�6H   $��Italic$�6e   $
��Bold"�6x   
����  �6�   5?      � 5@   
   $��2��6   $��2��6    5A      �� 5B      6"   �� 5C      6"   �� 5D      6"   .+�5G      �� -   5        $
��next��5G      $��1��6#   $
��10,0q�60   $��Italic$�6P   $
��Bold"�6c   
�������
����  �
����  �.��6�   %#Следующая страница5I      5J      5L      5M      