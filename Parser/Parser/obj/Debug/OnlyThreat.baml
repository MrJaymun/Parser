   M S B A M L   `   `   `  ����A  =Parser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ParserParser  5   	       Parser.OnlyThreat   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Parser     5   	     � Title$  
OnlyThreat��5   	   $	��550��6   $	��800��6)   $	��550��65   $	��800��6E    � WindowStartupLocation$ CenterScreen=�6T   .��5	      �  � RowDefinitions 5
   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   .+�5!   
   �� $f��`Введите ID угрозы, информацию о которой хотите узнать��6   $��1��6Q   $��0��6^   $��2��6n   $
��Wrap=�6�   $��Center=�6�   $��Center=�6�   $��10,7,0,5q�6�   $��18��6�   $��Italic$�6�   $
��Bold"�6�   
����  �6  �� 5"   
   -   5        $��ChooseId��5"      $��1��6"   $��2��6/   $��0,7,0,5q�6?   �� 5#   
   -   5        $��ChooseIdButton��5#      $��1��6'   $��3��64   $��	10,7,10,5q�6D   $��Italic$�6h   $
��Bold"�6{   
�������
����  �
����  �.��6�   Подтвердить5%      �� 5&   
   $#��Название угрозы��6   $��2��6+   $��0��68   $��2��6H   $��Center=�6Y   $��10,11q�6t   $��Center=�6�   $��Italic$�6�   $
��Bold"�6�   
����  �6�   �� 5'   
   -   5        $
��name��5'      $��2��6   $��1��6+   $��3��6;   $��2��6P    �� 
IsReadOnly . $��
0,10,10,10q�6t    �� TextWrapping$
 Wrap=�6�   �� 5)   
   $#��Описание угрозы��6   $��4��6+   $��0��68   $��2��6H   $��Center=�6Y   $��10,11q�6t   $��Center=�6�   $��Italic$�6�   $
��Bold"�6�   
����  �6�   �� 5*   
   -   5        $��description��5*      $��4��6%   $��1��62   $��3��6B   $��2��6W    . $��
0,10,10,10q�6{   $
 Wrap=�6�   �� 5,   
   $#��Источник угрозы��6   $��6��6+   $��0��68   $��2��6H   $��Center=�6Y   $��10,11q�6t   $��Center=�6�   $��Italic$�6�   $
��Bold"�6�   
����  �6�   �� 5-   
   -   5        $��source��5-      $��6��6    $��1��6-   $��3��6=   $��2��6R    . $��
0,10,10,10q�6v   $
 Wrap=�6�   �� 5/   
   $)��#Объект воздействия��6   $��8��6.   $��0��6;   $��2��6K   $��Center=�6\   $��10,11q�6w   $��Center=�6�   $��Italic$�6�   $
��Bold"�6�   
����  �6�   �� 50   
   -   5        $��	objective��50      $��8��6#   $��1��60   $��3��6@   $��2��6U    . $��
0,10,10,10q�6y   $
 Wrap=�6�   �� 52   
   $=��7Нарушение конфиденциальности��6   $��10��68   $��1��6F   $��Center=�6W   $��Center=�6s   $��Italic$�6�   $
��Bold"�6�   
����  �6�   �� 53   
   -   5        $
��conf��53      $��10��6!   $��2��6/   $��Center=�6@   $��Center=�6\   �� 55   
   $1��+Нарушение целлостности��6   $��11��62   $��1��6@   $��Center=�6Q   $��Center=�6m   $��Italic$�6�   $
��Bold"�6�   
����  �6�   �� 56   
   -   5        $��integ��56      $��11��6"   $��2��60   $��Center=�6A   $��Center=�6]   �� 58   
   $/��)Нарушение доступности��6   $��12��61   $��1��6?   $��Center=�6P   $��Center=�6l   $��Italic$�6�   $
��Bold"�6�   
����  �6�   �� 59   
   -	   5        $��avail��59      $��12��6"   $��2��60   $��Center=�6A   $��Center=�6]   �� 5;   
   -
   5        $��error��5;      
���  ��$��14��63   $��1��6A   $��2��6Q   $��Center=�6f   $��Center=�6�   �� 5=   
   -   5        $
��Back��5=      $��13��6   $��1��6+   $��2��6;   $��	10,7,10,5q�6O   $��Italic$�6u   $
��Bold"�6�   
�������
����  �
����  �.��6�   Вернуться5?      5@      5A      