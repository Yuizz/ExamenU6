   M S B A M L   `   `   `  ����C  ?ExamenU6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ExamenU6.ModulosExamenU6.Modulos  5      *    $ExamenU6.Modulos.UsuariosUserControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:ExamenU6.Modulos     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   � $��0��6   .+�5      ��    LabelTitulo#��[  6   $��  Usuarios  ��69   6R   �� 5      -   5        $��addUser��5        
btnAgregar#��[ 6$   6H   �� 5      -   5        $��editUser��5        	btnEditar#��[ 6%   6H   �� 5      -   5        $��
updateList��5        btnActualizar#��[ 6'   6N   5      � 5   
   $��1��6     BrushPrimaryColor#��[ 6   $��0q�6L   .+�5      �� -   5        $��listUsuarios��5   "   $��5q�6    �� View 5      �� 5      .P�5      �� $��Nombre��6)    �� Width$
 auto��69    �� DisplayMemberBinding 6F   �� *Name+�� 5      $��	Direccion��6)   $
 auto��6<    6I   �� *	Address+�� 5      $
��RFID��6)   $
 auto��67    6D   �� *Rfid+�� 5      $��Numero de control��6)   $
 auto��6D    6Q   �� *	CtrlNum+�� 5      $��Departamento��6)   $
 auto��6?    6L   �� *	Deparment+5      5      5       5!      5"      