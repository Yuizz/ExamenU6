   M S B A M L   `   `   `  ����C  ?ExamenU6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ExamenU6ExamenU6  5   	       ExamenU6.EditUserWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:ExamenU6     5   	   -   5          � Title$  Editar Usuario��5   	    � Icon$ ../imag/usuarios.png��6    $	��240��6<   $	��380��6I    � 
ResizeMode$ NoResize=�6U   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6      BrushPrimaryColor#��[  6"   .+�5   
   �� $��Times New Roman)�6   $��24(�6-   $��10q�6;   $��Center=�6G     LabelTitulo#��[ 6d   .��6�   Editar usuario6�   5      � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   .+�5      �� $��10, 0q�6   $��0��6(   .+�5      �� $
��0, 5q�6   $��14(�6*   	Nombre:6A   �� 5      $
��0, 5q�6   $��14(�6*   Dirección:6D   �� 5      -   5         ��Name$ TarjetaRFID��5      $��	5,13, 5,5q�6.   $��14(�6A     
btnAgregar#��[ 6i   $
��auto��6�   $
��auto��6�   .��6�   Tarjeta RFID6�   5      �� 5      $��10, 0q�6   $��1��6(   .+�5      �� -   5        $��nombre��5      $	��153��6(   $	��0,5q�64   $��14(�6A   6O   �� 5      -   5        $��	direccion��5      $	��153��6+   $	��0,5q�67   $��14(�6D   6R   �� 5      -   5        $
��RFID��5      $	��153��6&   $��0,2,0,5q�62   $��14(�6C    �� 
IsReadOnly . 6Q   5       5!      � 5"   
   $��2��6   $	��0,5q�6!   $��Center=�6.   .+�5#      �� -   5        $��Guardar��5#      $	��5,5q�6$     
btnGuardar#��[ 61   $��  Guardar  ��6U    J� 
RenderSize$ 50,100��6k   $��14(�6   6�   �� 5$      -   5        $��Cancelar��5$      $	��5,5q�6%     btnCancelar#��[ 62   $��  Cancelar  ��6W   $��14(�6n   6|   5%      5&      5'      