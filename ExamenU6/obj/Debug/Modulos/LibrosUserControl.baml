   M S B A M L   `   `   `  ����C  ?ExamenU6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ExamenU6.ModulosExamenU6.Modulos  5      (    "ExamenU6.Modulos.LibrosUserControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:ExamenU6.Modulos     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   � $��0��6   .+�5      ��    LabelTitulo#��[  6   $��      Libros      ��69   6X   �� 5      -   5        $��lendBook��5        btnPedir#��[ 6%   6G   �� 5      -   5        $��
returnBook��5        btnDevolver#��[ 6'   6L   �� 5      -   5        $��
updateList��5        btnActualizar#��[ 6'   6N   5      � 5   
   $��1��6     BrushPrimaryColor#��[ 6   $��0q�6L   .+�5      �� -   5        $��
listLibros��5   "   $��5q�6    �� View 5      �� 5      .P�5      �� $��Título��6)    �� Width$
 auto��69    �� DisplayMemberBinding 6F   �� *Title+�� 5      $��Autor��6)   $
 auto��68    6E   �� *Author+�� 5      $��	Editorial��6)   $
 auto��6<    6I   �� *	Editorial+�� 5      $��Estado��6)   $
 auto��69    6F   �� *Status+�� 5      $��Dueño��6)   $
 auto��68    6E   �� *	OwnedBy+5      5      5       5!      5"      