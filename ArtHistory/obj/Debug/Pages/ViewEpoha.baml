   M S B A M L   `   `   `  ����E  AArtHistory, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ArtHistory.PagesArtHistory.Pages  5           ArtHistory.Pages.ViewEpoha   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:ArtHistory.Pages     5        N� 
Background
  ����� N� Title$ 	ViewEpoha��5	      $
��auto��6   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��759* �6   �� 5      $��60 �6    � RowDefinitions 5   
   �� 5      $
��200* �6   �� 5      $	��85* �6   .+�5   
   �� $��0��6   $��2��6"   .+�5      �� -   5         ��Name$ imageElement��5      $	��400��6*   $��10q�6;   6J   5      �� 5   
   $��1��6   $��2��6"   .+�5      �� $"��Название эпохи:��6   $��Center=�6.   �� 5      -   5         ��Name$ tbName��5   (    �� 
IsReadOnly . $
��auto��68   $��16(�6E   $��SemiBold"�6S   
������ $��0q�6�   $��Center=�6�   6�   �� 5      $��	Даты:��6   $��Center=�6$   �� 5      -   5        $ tbDate��5   (    . $
��auto��68   $��16(�6E   $��SemiBold"�6S   
������ $��0q�6�   $��Center=�6�   6�   �� 5       -   5         ��Name$ 
tbOpisanie��5       
������ " �� VerticalScrollBarVisibility$
 Auto=�6G   $��
10,5,10,20q�6j    . $��0q�6�   . �5!      /� .T�5"      J� 	 �� 
LineHeight$	 1��6    .*�6/   .*�5#   ?   5$      5%      5&      5'      5.      5/      