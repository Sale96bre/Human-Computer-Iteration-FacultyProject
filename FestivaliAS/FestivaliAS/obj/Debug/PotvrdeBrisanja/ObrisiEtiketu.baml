   M S B A M L   `   `   `  ����F  BFestivaliAS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:FestivaliAS.ViewModelsFestivaliAS.ViewModels  5   	   /    )FestivaliAS.PotvrdeBrisanja.ObrisiEtiketu   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:FestivaliAS.ViewModels     5   	     � Title$  Obrisati Etiketu?��5   	    � Icon$- '/../Images/icons8-data-sheet-35 (2).png��6#   $	��640��6S   $	��860��6`    � 
ResizeMode$ NoResize=�6l    � WindowStartupLocation$ CenterScreen=�6�    � 	Resources 5	      -  'FestivaliAS.ViewModels.EtiketaViewModel   DataContext��%   &	          5
   
   6!   5      .��5      � ���#9DB6A4 � DataContext 6   ��  �� Source# [  .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��tipGrid��5      
�������   AutoGenerateColumns .     
IsReadOnly . $��22,120,28,150q�6�   $��20(�6�   $��Arial)�6�   ��6Y   �� * ManifestacijeKojeSadrzeEtiketu+	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Jedinstvena oznaka��6%      MinWidth$	 200Q�6A      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6P   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6Z   �� *Id+  5      $
 Naziv��6%   $	 200Q�65   $ * 6D    6N   �� *Name+4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 Ikonica��6)   $	 200Q�6:   $ * 6I      CellTemplate 5      �� 5      .R�5      �� ��6$   �� *
IconPath+5      5        5      $

 Opis��6%   $	 200Q�63   $ * 6B    6L   �� *Opis+5      �� 5!   
   -   5         ��Name$ FilterTipova��5!      
���iii�
�������$��2q�6W   $
��Left=�6l   $��DemiBold"�6�   $��	22,10,0,0q�6�   $��24(�6�   $��Arial)�6�   $	��Top=�5"      $��94��6+   $	��804��67   .��5#      � .+�5&      �� $5��/Selektovana etiketa se nalazi u manifestacijama��6   $��Normal"�6R   $��20(�6f   $��Arial)�6u   $��10,15,101,37q�6�   6�   �� 5'      $T��NU slučaju brisanja, ova etiketa se takođe briše iz navedenih manifestacija:��6   $��Normal"�6n   $��20(�6�   $��Arial)�6�   $��10,51,-51,5q�6�   6�   5)      5*      �� 5+   
   -   5         ��Name$ Izadji��5+      $��Odustani��6V   $
��Left=�6i   $	��106��6�   $��22(�6�   $��Arial)�6�   
�������$��485,517,0,51q�6�   ��6!   �� *" OdustaniOdBrisanjaEtiketeCommand+6�   �� 5,   
   -   5        $ Delete��5,      $��Izbriši��6Z   $
��Left=�6l   
�������$��22(�6�   $��Arial)�6�   $	��106��6�   $��246,517,0,51q�6�   ��6!   �� *%#ObrisiEtiketuSadrzanuUManifestaciji+6�   5/      50      