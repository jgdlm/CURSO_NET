   M S B A M L   `   `   `  ����K  GWPFInyecciónSQL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WPFInyecciónSQLWPFInyecciónSQL  5   	   !    WPFInyecciónSQL.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:WPFInyecciónSQL     5   	     � Title$  
MainWindow��5   	   $��686.649��6   $��1207.084��6-   .��5	      � $��	0,0,37,12q�6   .+�5
   
   �� $
��Left=�6   $	��577��60   $��
28,44,0,15q�6=   $	��Top=�6Q   $	��187��6i   ���	#FFE8E6E6.+�5      �� $��INSERTAR��6   $
��Bold"�6'   $��20(�69   $��	32,0,34,0q�6G   �� 5      -   5         ��Name$ TxtID��5      $��35��6%    �� TextWrapping$
 Wrap=�61   $��	12,0,9,15q�6E   �� 5      -   5        $ 	TxtNombre��5      $��35��6)   $
 Wrap=�65   $��	12,0,9,15q�6I   �� 5      -   5        $ TxtEdad��5      $��35��6'   $
 Wrap=�63   $��12,0,9,0q�6G   �� 5      -   5         ��Name$ BtnInsertar��5      $��Botón Insertar��6*   $��	12,15,9,0q�6C   $��39��6V   ���	#FFECBB17$��20(�6y   
�������6�   5      �� 5   
   $
��Left=�6   $	��577��60   $��
240,44,0,0q�6=   $	��Top=�6Q   $	��213��6i   ���	#FFE8E6E6.+�5      �� $��ELIMINAR��6   $
��Bold"�6'   $��20(�69   $��	42,0,34,0q�6G   �� 5      -   5        $ TxtID1��5      $��35��6&   $
 Wrap=�62   $��	12,0,9,15q�6F   �� 5      -   5         ��Name$ Label1��5      $��Nombre��6$   $
��Bold"�65   $��20(�6G   $��
42,0,34,15q�6U   ���	#FFF7F9FB���	#FF2872F36�   �� 5      -   5        $ Label2��5      $
��Edad��6$   $
��Bold"�63   $��20(�6E   $��	42,0,34,0q�6S   ���	#FFF7F9FB���	#FF2872F36}   �� 5      -   5        $ BtnConsulta��5      $��Consulta��6*   $��
12,15,92,0q�6=   $��39��6Q   ���	#FFECBB17$��20(�6t   
�������6�   �� 5      -	   5        $ BtnEliminar��5      $��Eliminar��6*   $��
14,15,90,0q�6=   $��39��6Q   ���	#FFECBB17$��20(�6t   
�������{�.  6�   5      �� 5   
   $
��Left=�6   $	��577��60   $��
477,44,0,0q�6=   $	��Top=�6Q   $	��212��6i   ���	#FFE8E6E6.+�5      �� $��	MODIFICAR��6   $
��Bold"�6(   $��20(�6:   $��	29,0,30,0q�6H   �� 5      -
   5        $ TxtID2��5      $��35��6&   $
 Wrap=�62   $��6,0,3,15q�6F   �� 5      -   5        $ BtnBusca��5      $��Busca��6'   $��55,15,48,15q�67   $��39��6L   ���	#FFECBB17$��20(�6o   
�������6�   �� 5      -   5        $ 
TxtNombre1��5      $��35��6*   $
 Wrap=�66   $��6,0,3,15q�6J   �� 5      -   5        $ TxtEdad1��5      $��35��6(   $
 Wrap=�64   $��6,0,3,15q�6H   �� 5      -   5        $ BtnModifica��5      $��Modifica��6*   $��55,15,48,15q�6=   $��39��6R   ���	#FFECBB17$��20(�6u   
�������{�.  6�   5       &   System.Windows.Controls.DataGrid  5!   
   -   5          Name$ DataGridDatos��5!      $
��Left=�6*   $	��566��6E   $��
705,55,0,0q�6R   $	��Top=�6f   $	��456��6~   ���	#FFEAEAEA6�   5#      5$      