   M S B A M L   `   `   `  ����E  AArtHistory, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ArtHistory.PagesArtHistory.Pages  5      "    ArtHistory.Pages.ViewKartina   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:ArtHistory.Pages     5        N� Title$  ViewKartina��5       N� 
Background
 �����.��5      �  � ColumnDefinitions 5   
   �� 5      $
��759* �6   �� 5      $	��50* �6    � RowDefinitions 5   
   �� 5      $	��66* �6   �� 5      $	��85* �6   .+�5   
   �� $��0��6   $��2��6"   .+�5      �� -   5         ��Name$ imageElement��5      $	��400��6*   $��10q�6;   6I   5      �� 5   
   $��1��6   $��2��6"   .+�5      �� $%��Название картины��6   $��Center=�6/   �� 5      -   5         ��Name$ tbName��5   (    �� 
IsReadOnly . $��16(�68   $��SemiBold"�6F   $
��auto��6\   
������ $��0q�6�   $��Center=�6�   6�   �� 5       $��
Автор��6   $��Center=�6$   �� 5!      -   5        $ tbAvtor��5!   (    . $
��auto��69   $��16(�6G   $��SemiBold"�6U   
������ $��0q�6�   $��Center=�6�   6�   �� 5#      $��Дата создания��6   $��Center=�6,   �� 5$      -   5        $ tbDate��5$   )    . $
��auto��69   $��16(�6G   $��SemiBold"�6U   
������ $��0q�6�   $��Center=�6�   6�   �� 5&      -   5         ��Name$ 
tbOpisanie��5&   ;   $��14(�6    . 
������ " �� VerticalScrollBarVisibility$
 Auto=�6h   $��
15,5,15,40q�6�   $��0q�6�   . �5'      /� .T�5(      J� 	 �� 
LineHeight$	 1��6    .*�6/   .*�5)   ?   5*      5+      5,      5.      51      53      