   M S B A M L   `   `   `  ���� E  AArtHistory, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ArtHistory.PagesArtHistory.Pages  !    ArtHistory.Pages.AddKartina   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     0localclr-namespace:ArtHistory.Pages     $
��Auto��  N� Title$  
AddKartina�� N� 
Background
 �����.���  � RowDefinitions �� $	��255 ��� $
��240* �.+��� $��0��$��0��
�������$	��180��$	��330��$��0, 0, 0, 59q��� $��0��$��0��.+��� -    ��Name$ selectedImage��$	��180��$	��330��$��
0, 7, 0, 5q��� -    ��Name$ selectedImagePath��$�� ��$
��Bold"�$��0,0,0,0q�$��Center=�$	��381���� -    ��Name$ btnSelectImage��$+��%Выбрать изображение��$	��150��$��26��$��5q��� $	��Top=�$��1��$��10q�.+��� $y�Visible=�
����  �$��
10,0,10,10q���  �� Orientation$ 
Horizontal=�.+��� $��Название:��$��72��$
��Left=��� -    ��Name$ tbName��$	��550��$��10,5,0,5q�$��24���� $ 
Horizontal=�.+��� $��Автор:���� -   $ tbAvtor��$	��550��$��35,5,0,5q�$��24���� $ 
Horizontal=�.+��� $��	Дата:���� -   $ tbDates��$	��200��$��43,5,0,5q�$��24���� $��Описание:��$��Stretch=��� -    ��Name$ 
tbOpisanie��"	 �� VerticalScrollBarVisibility$
	 Auto=�$	��150��$
��auto��$	��400��$��
10,0,10,10q�
 �� 
IsReadOnly
 .  . �/� .T�J�  �� 
LineHeight$	 1.2��.*�.*��� $ 
Horizontal=�$��Center=�$��5q�$��2��.+��� -   $ 	btnOtmena��$��Отменить��$��
0,5, 30, 5q�$��25��$��90���� -	   $ btnSave��$��Сохранить��$��	0,5, 0, 5q�$��25��$��90��