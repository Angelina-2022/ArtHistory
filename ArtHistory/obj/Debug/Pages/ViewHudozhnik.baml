   M S B A M L   `   `   `  ����E  AArtHistory, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ArtHistory.PagesArtHistory.Pages  5      $    ArtHistory.Pages.ViewHudozhnik   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:ArtHistory.Pages     5      $
��auto��5        N� Title$  ViewHudozhnik��5       N� 
Background
 �����.��5      �  � RowDefinitions 5   
   �� 5      $
��250* �6   �� 5      $	��28* �6    � ColumnDefinitions 5   
   �� 5      $	��10* �6   �� 5      $	��27* �6   �� 5      $��60 �6   .+�5   
   �� -   5         ��Name$ imageElement��5      $	��300��6&   $
��auto��66   $��Uniform=�6C   $��0��6U   $��0��6b   $��10q�6r   �� 5   
   $��1��6   $��	10,0,10,0q�6%   $��Center=�68   $	��142��6S   .+�5      �� $��ФИО��6   �� 5      -   5         ��Name$ tbFIO��5   (    �� 
IsReadOnly . $
��auto��67   $��16(�6D   $��SemiBold"�6R   
������ $��0q�6�   $
��Left=�6�   6�   �� 5      $��годы жизни��6   �� 5      -   5        $ tbDate��5   )    . $
��auto��69   $��16(�6G   $��SemiBold"�6U   
������ $��0q�6�   $
��Left=�6�   6�   �� 5      $��Эпоха:��6   �� 5       -   5        $ tbEpoha��5    (    . $
��auto��69   $��16(�6G   $��SemiBold"�6U   
������ $��0q�6�   $
��Left=�6�   6�   5"      �� 5$   
   $��1��6   $��3��6#   .+�5&      �� -   5         ��Name$ tbBiografia��5&   +   $��14(�6   
������ " �� VerticalScrollBarVisibility$
 Auto=�6Y   $��
15,5,15,30q�6|    . $��0q�6�   . �5'      /� .T�5(      J� 	 �� 
LineHeight$	 1��6    .*�6/   .*�5)   ?   5*      5+      5,      5-      52      53      