   M S B A M L   `   `   `  ����E  AArtHistory, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ArtHistory.PagesArtHistory.Pages  5          ArtHistory.Pages.Slovar   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:ArtHistory.Pages     5        N� Title$  Slovar��5	       N� 
Background
 �����.��5      �  � RowDefinitions 5   
   �� 5      $��45 �6   �� 5      $��8* �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6#   $��Stretch=�6<   ���#DFFFB4.+�5      �� -   5        $��А-Я��5      $��30��6?   $��5q�6K   $��20,0,5,0q�6W   
������|�. 6�   �� 5      -   5        $��Я-А��5      $��30��6@   $��5q�6L   $��5,0,5,0q�6X   
������6i   �� 5      -   5        $��Избранное��5      $��30��6E   $��5q�6Q   $��20,0,5,0q�6]   ���#5EC7BF6o   �� 5      -   5        $��Все записи��5      $��30��6<   $��5q�6H   $��20,0,5,0q�6T   ���#5EC7BF6f   �� 5      -   5         ��Name$ searchTextBox��5      $��20,0,5,0q�6O   $��Center=�6a   $	��250��6|   $��25��6�   �� 5      $0��*IconResources/free-icon-search-2414255.png��6   $��40��6H   $��40��6S   $��0,0,5,0q�6_   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ ItemsControl��5       $��1��6      AutoGenerateColumns .     CanUserAddRows .  ��66   �� *Items+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn	   Header$	 Термин��6&   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 200 6Q      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *Termin+   ElementStyle 5!      �� 5"       �� 
TargetType" ��6    .�5#      ��  �� Property � �� �� Value$ 13(�6C   �� 5$       � ��$	 Top=�6L   �� 5%       � ��$
 Wrap=�6G   5&      5(        5)      $	 Описание��6%   $
 * 6T    .  67   �� *
Opisanie+ 5*      �� 5+      " ��6    .�5,      ��  � ��$ 13(�6C   �� 5-       � ��$	 Top=�6L   �� 5.       � ��$
 Wrap=�6G   5/      51      4  .System.Windows.Controls.DataGridTemplateColumn  52      $	  ��6)   $	
 130 63      CellTemplate 53      �� 54      .R�55      �� $ 
Horizontal=�6)   .+�56   "   �� -   5         � ToolTip$  редактировать��56   )   
������ $��25��6Z   $��25��6f   $��15,5,5,5q�6q   $��0q�6�   ��6�   �� ��57   &   �� 58   *   $��/Resources/3388898.png��60   5:   #   �� 5;   "   -   5        $ удалить��5;   *   
������ $��25��6V   $��25��6b   $��5q�6m   $��0q�6y   ��6�   �� ��5<   &   �� 5=   *   $��\Resources\3893833.png��60   5?   #   �� 5@   "   -	   5        $, &добавить в избранное��5@   *   
������ $��25��6c   $��25��6o   $��5q�6z   $��0q�6�   ��6�   �� ��5A   &   �� 5B   *   $��\Resources\2099045.png��60   5D   #   5E      5F      5H      5J      5K      5N      