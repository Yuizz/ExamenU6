   M S B A M L   `   `   `  ����C  ?ExamenU6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ExamenU6ExamenU6  5   	       ExamenU6.AddUserWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:ExamenU6     5   	   -   5          � Title$  Añadir usuario��5   	    � Icon$  ../imag/agregarUsuario.png��6    $	��330��6B   $	��370��6O    � 
ResizeMode$ NoResize=�6[   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   ��    BrushPrimaryColor#��[  6   .+�5   
   �� $��0��6   $��Times New Roman)�6   $��24(�6:   $��10q�6H   $��Center=�6T     LabelTitulo#��[ 6q   .��6�   Añadir usuario6�   5      � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   .+�5      �� $��10, 0q�6   $��0��6(   .+�5      �� $
��0, 5q�6   $��14(�6*   	Nombre:6A   �� 5      $
��0, 5q�6   $��14(�6*   Dirección:6E   �� 5      -   5         ��Name$ TarjetaRFID��5      $��5, 12, 5, 5q�6.   $��14(�6C     	btnSimple#��[ 6k   $
��auto��6�   $
��auto��6�   .��6�   Tarjeta RFID6�   �� 5      $	��0,5q�6   $��14(�6)   
Usuario:6A   �� 5      -   5        $��Dato4��5      $
��0,17q�6)   $��14(�67   $�� ��6E   6O   5      �� 5      $��10, 0q�6   $��1��6(   .+�5      �� -   5        $��nombre��5      $	��153��6(   $	��0,5q�64   $��14(�6A   6O   �� 5       -   5        $��	direccion��5       $	��153��6+   $	��0,5q�67   $��14(�6D   6R   �� 5!      -   5        $
��RFID��5!      $	��153��6&   $��0,2,0,5q�62   $��14(�6C    �� 
IsReadOnly . 6Q   	� 5"      -   5        $��
btnStudent��5"      $��0,5,0,1q�60   $��
Estudiante��6A   6q   	� 5#      -   5        $��
btnTeacher��5#      $��0,1,0,5q�60   $��Docente��6A   6n   �� 5$      -	   5        $��boxDato4��5$      $	��153��6*   $��0,5, 0,5q�66   $��14(�6H   $y�Hidden=�6y   5%      5&      � 5'   
   $��2��6   $	��0,5q�6!   $��Center=�6.   .+�5(      �� -
   5        $��Guardar��5(      $	��5,5q�6$   $��  Guardar  ��61    J� 
RenderSize$ 50,100��6G   $��14(�6[     
btnGuardar#��[ 6   �� 5)      -   5        $��Cancelar��5)      $	��5,5q�6%   $��  Cancelar  ��62   $��14(�6I     btnCancelar#��[ 6n   5*      5+      5,      