   M S B A M L   `   `   `  ����A  =Parser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ParserParser  5   	       Parser.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Parser     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � WindowStartupLocation$ CenterScreen=�65   $	��650��6Z   $	��400��6i   .��5	      �  � RowDefinitions 5
   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   .+�5   
   �� -   5        $��watchAll��5      $��1��6!   $��1��6.   $��Italic$�6W   $
��Bold"�6j   
�������
����  �
����  �.��6�   .,Просмотр списка записей5       �� 5!   
   -   5        $��	watchOnly��5!      $��3��6"   $��1��6/   $��Italic$�6Q   $
��Bold"�6d   
�������
����  �
����  �.��6�   75Просмотр информации о записи5#      �� 5%   
   -   5        $��refresh��5%      $��5��6    $��1��6-   $��Italic$�6M   $
��Bold"�6`   
�������
����  �
����  �.��6�   Обновить данные5'      �� 5)   
   -   5        $��savetxt��5)      $��7��6!   $��1��6/   $��Italic$�6L   $
��Bold"�6_   
�������
����  �
����  �.��6�   !Сохранить данные5+      �� 5,   
   -   5        $
��exit��5,      $��9��6   $��1��6,   $��Italic$�6I   $
��Bold"�6\   
�������
����  �
����  �.��6�   
Выход5.      50      52      