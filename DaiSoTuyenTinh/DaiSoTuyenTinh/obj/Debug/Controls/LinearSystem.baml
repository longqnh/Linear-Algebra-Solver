   M S B A M L   `   `   `  ����I  EDaiSoTuyenTinh, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:DaiSoTuyenTinh.ControlsDaiSoTuyenTinh.Controls  5      *    $DaiSoTuyenTinh.Controls.LinearSystem   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:DaiSoTuyenTinh.Controls     5      $	��369��5      $	��400��6,   .��5      � .+�5	   
   �� $��	10,10,0,0q�6   $
��Wrap=�6'   $#��Nhập số phương trình: ��6;   $��16(�6Y   $
��Left=�6g   $	��Top=�6�   �� 5
   
   -   5          ��Name$  lbError��5
      $y�Hidden=�6!   $&�� Số phương trình phải >= 1��65   $��9(�6Y   
���  ��$
��Left=�6w   $	��Top=�6�   $��	198,8,0,0q�6�   �� 5   
   $��
118,67,0,0q�6   $
��Wrap=�6(   $#��Nhập các phương trình: ��6<   $��16(�6[   $
��Left=�6i   $	��Top=�6�   �� 5   
   -   5         ��Name$ listEqs��5      $	��227��6$   $��5,93,0,0q�61   $	��395��6C   $	��Top=�6O   $
��Left=�6g   �� 5   
   -   5         ��Name$ btnStart��5      $��Giải��6#   $��14(�6I   $
��Left=�6W   $��171,332,0,0q�6r   $	��Top=�6�   $��75��6�   �� 5   
   -   5         ��Name$ tbNumEquations��5      $��
180,10,0,0q�6*    �� TextWrapping$
 Wrap=�6>   $��2��6R   $��Center=�6�   $��Center=�6�   $
��Left=�6  $	��Top=�6/  $��21��6G  $��26��6S  �� 5   
   -   5        $ tbRandom��5      $��Tạo Ngẫu nhiên��6#   $��14(�6S   $��
46,332,0,0q�6a   $
��Left=�6v   $	��Top=�6�   $	��108��6�   �� 5   
   $
��Left=�6   $��	10,36,0,0q�6/   $
��Wrap=�6B   $$��Chọn phương pháp giải: ��6V   $	��Top=�6u   $��26��6�   $	��189��6�   $��16(�6�   �� 5   
   -   5         ��Name$ cmbQuestion��5      $
��Left=�6(   $��
213,36,0,0q�6C   $	��Top=�6W   $	��124��6o   .@�5      �� $��Cramer��6    �� 
IsSelected . 6,   �� 5      $��Gauss - Jordan��6   5      �� 5   
   -   5        $ ShowSol��5      $��Xem Lời Giải��6"   $��14(�6O   $��270,332,0,0q�6]   $
��Left=�6s   $	��Top=�6�   $	��108��6�   5      5      