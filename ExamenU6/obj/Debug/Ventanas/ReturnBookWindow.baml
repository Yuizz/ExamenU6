   M S B A M L   `   `   `  ����C  ?ExamenU6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ExamenU6.VentanasExamenU6.Ventanas  5   	   (    "ExamenU6.Ventanas.ReturnBookWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:ExamenU6.Ventanas     5   	   -   5          � Title$  Devolver Libro��5   	    � Icon$ ../imag/devLibro.png��6    $	��450��6<   $	��300��6I   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6      BrushPrimaryColor#��[  6"   .+�5      �� $��Devolver libros��6   $��24(�6.   $��Times New Roman)�6<   $��Center=�6Y     LabelTitulo#��[ 6}   5      �� 5   
   $��1��6   $��10q�6"   .+�5      �� -   5        $
��RFID��5      $��14(�6"    �� 
IsReadOnly . $��20,10q�6B   $
��auto��6Q   $��Center=�6^   6�   �� 5      -   5        $��scanCard��5      $
��40,0q�6%   $��14(�63     	btnSimple#��[ 6[   $
��auto��6~   .��6�   Escanear tarjeta6�   5      �� 5   
   -   5        $��usuario��5   !   $��2��6   $
��20,1q�60   $��12(�6>   $
��Bold"�6L   6`   � 5   
   $��3��6   #��[  6   $��0q�6L   .+�5      �� -   5        $��
listLibros��5   "   $��5q�6    �� View 5      �� 5      .P�5      �� $��Título��6)    �� Width$
 auto��69    �� DisplayMemberBinding 6F   �� *Title+�� 5      $��Autor��6)   $
 auto��68    6E   �� *Author+�� 5      $��	Editorial��6)   $
 auto��6<    6I   �� *	Editorial+5       5"      5#      � 5$   
   $��4��6   $
��10,5q�6    � ColumnDefinitions 5%      �� 5&      $��* �6#   �� 5'      $��* �6#   .+�5)      �� -   5        $��devolverLibro��5)   %   $��0��6   $��  Devolver libro  ��6:   $
��10,0q�6W     
btnGuardar#��[ 6�   �� 5*      -   5        $��cancelar��5*   %   $��1��6   $��  Cancelar  ��65   $
��10,0q�6L     btnCancelar#��[ 6q   5+      5,      5-      