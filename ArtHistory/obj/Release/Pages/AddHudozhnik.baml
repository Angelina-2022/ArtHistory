   M S B A M L   `   `   `  ���� E  AArtHistory, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ArtHistory.PagesArtHistory.Pages  #    ArtHistory.Pages.AddHudozhnik   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     0localclr-namespace:ArtHistory.Pages     $
��Auto��  N� Title$  AddHudozhnik�� N� 
Background
 �����.��� .+�� $��10q� � RowDefinitions �� $	��250 ��� $��40 ��� $	��84* � � ColumnDefinitions �� $	��200 ��� $
��135* ��� $��55 �.+��� $��0��$��0��
�������$��5q��� -    ��Name$ selectedImage��$	��252��$
��Auto��$��0��$��0���� $��выбрать фото��$��1��$��0��$��5q�$��25���� $��0��$��1��$��
5,50,10,34q�$
��auto��.+��� $��ФИО���� -    ��Name$ tbFIO��$��0,0,0,7q�$��20���� $��годы жизни���� -   $ tbDate��$��0,0,0,7q�$��20���� $��Эпоха:���� -   $ tbEpoha��$��20���� $��2��$��3��$��10,10,10,10q�.+��� $y�Visible=�
����  �$��10,10,10,10q��� $��Биография��$
��auto��$
��auto��$��10,0,0,5q��� -    ��Name$ tbBiografia��" �� VerticalScrollBarVisibility$
 Auto=�$	��150��$
��auto��$	��400��$��
10,0,10,10q� �� 
IsReadOnly .  . �/� .T�J� 	 �� 
LineHeight$		 1.2��.*�.*��� 
 �� Orientation$
 
Horizontal=�$��Center=�.+��� -    ��Name$ 	btnOtmena��$��Отменить��$��
0,5, 30, 5q�$��25��$��90���� -   $ btnSave��$��Сохранить��$��	0,5, 0, 5q�$��90��