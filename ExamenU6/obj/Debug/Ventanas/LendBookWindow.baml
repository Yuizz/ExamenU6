   M S B A M L   `   `   `  ����C  ?ExamenU6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ExamenU6ExamenU6  5   	       ExamenU6.LendBookWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:ExamenU6     5   	   -   5          � Title$  Prestar libro��5   	    � Icon$ ../imag/tomarLibro.png��6   $	��210��6=   $	��300��6J   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6      BrushPrimaryColor#��[  6"   .+�5      �� $��Prestar libro��6   $��24(�6,   $��Times New Roman)�6:   $��Center=�6W     LabelTitulo#��[ 6{   5      �� 5   
   $��1��6   $��10q�6"   .+�5      �� -   5        $
��RFID��5      $��14(�6"    �� 
IsReadOnly . $��20,10q�6B   $
��auto��6Q   $��Center=�6^   6�   �� 5      -   5        $��scanCard��5      $
��40,5q�6%   $��14(�63     	btnSimple#��[ 6[   $
��auto��6~   .��6�   Escanear tarjeta6�   �� 5      -   5        $��cancel��5      $��60, 5q�6#   $��14(�62     btnCancelar#��[ 6U   $
��auto��6z   .��6�   
Cancelar6�   5      5      5      