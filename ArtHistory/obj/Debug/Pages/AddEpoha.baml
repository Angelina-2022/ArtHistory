   M S B A M L   `   `   `  ����E  AArtHistory, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ArtHistory.PagesArtHistory.Pages  5          ArtHistory.Pages.AddEpoha   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:ArtHistory.Pages     5        N� Title$  AddEpoha��5       N� 
Background
 �����$
��auto��5	      .��5      � $
��auto��6    � RowDefinitions 5   
   �� 5      $	��245 �6   �� 5      $
��229* �6   .+�5   
   �� $��0��6   $��0��6"   $��0, -45, 0, 5q�62   
�������$	��159��6b   $	��334��6o   �� 5   
   $��5,0,5,0q�6   $��0��6&   .+�5      �� -   5         ��Name$ selectedImage��5      $	��159��6+   $	��334��68   $��0, 17, 0, 5q�6D   $��UniformToFill=�6\   �� 5      -   5         ��Name$ selectedImagePath��5      $�� ��6/   $
��Bold"�6:   $��0,0,0,0q�6L   $��Center=�6]   $
��auto��6z   �� 5      -   5         ��Name$ btnSelectImage��5      $+��%Выбрать изображение��6-   $	��150��6`   $��26��6l   $��0,0,0,10q�6y   �� 5      $y�Visible=�6   
����  �$��5,0,5,0q�6?   5      �� 5   
   $��8,10,8,0q�6   $
��auto��6'   $	��Top=�65   $��1��6M   $��2��6Z   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��8,0,0,0q�63   .+�5      �� $��Название:��6   $��72��6,   $
��Left=�67   �� 5      -   5         ��Name$ tbName��5      $	��550��6*   $��10,5,0,5q�66   $��24��6H   5       �� 5"      $ 
Horizontal=�6   $��8,0,0,0q�63   .+�5#      �� $��	Даты:��6   �� 5$      -   5        $ tbDates��5$      $	��200��6+   $��40,5,0,5q�67   $��24��6I   5%      �� 5'      $��Описание:��6   $��Stretch=�6(   $��8,0,0,0q�6G   �� 5(      -   5         ��Name$ 
tbOpisanie��5(      "	 �� VerticalScrollBarVisibility$
	 Auto=�6.   $	��150��6Q   $
��auto��6a   $	��400��6o   $��
10,0,10,10q�6   
 �� 
IsReadOnly
 .  . �5)      /� .T�5*      J�  �� 
LineHeight$ 1��6    .*�6/   .*�5+   ?   5,      5-      5.      �� 50      $ 
Horizontal=�6   $��Center=�62   .+�51      �� -   5        $ 	btnOtmena��51      $��Очистить��6,   $��
0,5, 30, 5q�6Z   $��25��6n   $��90��6z   �� 52      -   5        $ btnSave��52      $��Сохранить��6*   $��	0,5, 0, 5q�6W   $��90��6j   53      55      59      5;      