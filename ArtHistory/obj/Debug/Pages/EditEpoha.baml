   M S B A M L   `   `   `  ����E  AArtHistory, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ArtHistory.PagesArtHistory.Pages  5           ArtHistory.Pages.EditEpoha   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:ArtHistory.Pages     5        N� Title$  	EditEpoha��5	       N� 
Background
 �����.��5      �  � ColumnDefinitions 5   
   �� 5      $
��759* �6   �� 5      $��60 �6    � RowDefinitions 5   
   �� 5      $	��270 �6   �� 5      $	��85* �6   .+�5   
   �� $��0��6   $��2��6"   .+�5      �� -   5         ��Name$ imageElement��5      $	��200��6*   $	��563��67   $��Uniform=�6C   $��10q�6U   6d   �� 5      -   5         ��Name$ btnSelectImage��5      $+��%Выбрать изображение��6J   $	��150��6}   $��26��6�   $��0,9,0,0q�6�   ��6-   �� 6�   5      �� 5   
   $��1��6   $��2��6"   .+�5      �� $"��Название эпохи:��6   $��Center=�6.   �� 5      -   5         ��Name$ tbName��5   %   $	��160��6   $
��auto��65   $��16(�6B   $��SemiBold"�6P   $��Center=�6h   6�   �� 5       $��	Даты:��6   $��Center=�6$   �� 5!      -   5        $ tbDate��5!   %   $	��160��6   $
��auto��65   $��16(�6B   $��SemiBold"�6P   $��Center=�6g   6�   �� 5"      $��Описание:��6   $��	10,10,0,0q�6)   $
��auto��6<   �� 5$      -   5         ��Name$ 
tbOpisanie��5$   )   $��30��6   " �� VerticalScrollBarVisibility$
 Auto=�6>   $��
10,5,10,20q�6a   	 �� 
IsReadOnly	 .  . �5%      /� .T�5&      J� 
 �� 
LineHeight$
 1��6    .*�6/   .*�5'   ?   5(      5)      5*      5+      �� 5-   
   $��0��6   $��2��6"   $��Center=�62   .+�5.      �� -   5         � ToolTip$ сохранить��5.   K   
������ $��5q�6x   $��1q�6�   $��40��6�   $��40��6�   $��5,20,5,0q�6�   ��6   �� ��5/      �� 50      $��\Resources\2582598.png��6   52      �� 53      -   5        $ удалить��53   M   
������ $��5q�6x   $��1q�6�   $��40��6�   $��40��6�   $��5,20,5,0q�6�   ��6   �� ��54      �� 55      $��\Resources\3893833.png��6   57      59      5>      5?      