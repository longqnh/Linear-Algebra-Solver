   M S B A M L   `   `   `  ����I  EDaiSoTuyenTinh, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:DaiSoTuyenTinhDaiSoTuyenTinh  5   	   A%clr-namespace:DaiSoTuyenTinh.ControlsDaiSoTuyenTinh.Controls  5   	       DaiSoTuyenTinh.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:DaiSoTuyenTinh     5   	   :Controls%clr-namespace:DaiSoTuyenTinh.Controls     5   	   -   5          � 
ResizeMode$  CanMinimize=�5       � Title$ Linear Algebra Solver��5	   	   $	��482��6'   $	��855��64   .��5
      � .+�5   
   �� $
��Left=�6   $	��Top=�6/   $:��4Chọn giải Hệ phương trình hoặc ma trận:��6G   $
��Bold"�6v   $��18(�6�   $	��362��6�   $��31,0,0,0q�6�   �� 5   
   $
��Left=�6   $	��Top=�6/   $��Bài Giải Chi Tiết��6G   $
��Bold"�6`   $��18(�6r   $	��153��6�   $��
570,10,0,0q�6�   	� 5   
   -   5         	�Name$ rbHPT��5      $��Hệ phương trình��6=   $��	19,29,0,0q�6W   $��16(�6j   $��Center=�6x   $
��Left=�6�   $	��Top=�6�   	� 5   
   -   5        $
 rbMT��5      $��	Ma Trận��6;   $��
259,29,0,0q�6M   $��16(�6a   $��Center=�6o   $
��Left=�6�   $	��Top=�6�   �� 5   
   
���   �$��1q�6%   $
��Left=�69   $	��454��6T   $��	400,0,0,0q�6a   $	��Top=�6t   $��24��6�   �� 5   
   
���   �$��1q�6%   $
��Left=�69   $��3��6T   $��0,52,0,0q�6_   $	��Top=�6q   $	��400��6�   �� 5   
   
���   �$��1q�6%   $
��Left=�69   $��3��6T   $��
424,52,0,0q�6_   $	��Top=�6s   $	��425��6�   *   $DaiSoTuyenTinh.Controls.LinearSystem  5   
   -   5          Name$ 	LinearSys��5       $y�Hidden=�63   $
��Left=�6G   $��0,55,0,0q�6b   $	��Top=�6t   $   DaiSoTuyenTinh.Controls.Matrix  5   
   -   5          Name$ Matrix��5      $y�Hidden=�6*   $
��Left=�6>   $��0,55,0,0q�6Y   $	��Top=�6k   �� 5   
   -   5         ��Name$ 
lbSolution��5      $
��Left=�6&   $	��402��6A   $��
424,52,0,0q�6N   $	��Top=�6b   $	��415��6z   $��16(�6�   5      5      