   M S B A M L   `   `   `  ����@  <ONDE1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ONDE1ONDE1  5   	       ONDE1.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:ONDE1     5   	   -   5          � Title$  
MainWindow��5   	   $	��600��6   $	��800��6)   .��5	      ��  � 	Resources 5
   
    �� 
TargetType �� Property �� Value �� 
TargetType��%$  '��       �� 5      " ��6   .�5      ��  �@�OverridesDefaultStyle$
 True��6:   �� 5       � �� 5      �� 5      " ��6*   .R�5      � .+�5   "   A� 
���2͚�6*   �� 5   "   $��Center=�63   $��Center=�6P   5      5      5      5      5      .+�5   
   � .+�5      �� $��Mã bệnh nhân:��6   $
��Left=�6,   $��	50,50,0,0q�6G   $	��Top=�6Z   �� 5      $��
Họ tên:��6   $
��Left=�6&   $��
50,100,0,0q�6A   $	��Top=�6U   �� 5      $��Địa chỉ:��6   $
��Left=�6'   $��
50,150,0,0q�6B   $	��Top=�6V   �� 5      $��Số ngày nằm viên:��6   $
��Left=�60   $��
50,200,0,0q�6K   $	��Top=�6_   �� 5      $��Khoa khám:��6   $
��Left=�6)   $��
50,250,0,0q�6D   $	��Top=�6X   �� 5       -   5        $��txtmaBN��5       $
��Left=�6%   $��
200,50,0,0q�6@   $�� ��6T    �� TextWrapping$
 Wrap=�6\   $	��Top=�6p   $	��120��6�   �� 5!      -   5        $��txtHT��5!      $
��Left=�6#   $��200,100,0,0q�6>   $�� ��6S   $
 Wrap=�6[   $	��Top=�6o   $	��120��6�   �� 5"      -   5        $��txtDC��5"      $
��Left=�6#   $��200,150,0,0q�6>   $�� ��6S   $
 Wrap=�6[   $	��Top=�6o   $	��120��6�   �� 5#      -   5        $��txtSNNV��5#      $
��Left=�6%   $��200,200,0,0q�6@   $�� ��6U   $
 Wrap=�6]   $	��Top=�6q   $	��120��6�   �� 5$      -   5        $��cboKK��5$      $
��Left=�6$   $��200,250,0,0q�6?   $	��Top=�6T   $	��120��6l   &   System.Windows.Controls.DataGrid  5&      -   5          Name$ dgvBenhNhan��5&   /   $��45,292,108,134q�6      AutoGenerateColumns$ False��6D   	   CanUserAddRows$	 False��6`   
   AlternatingRowBackground

 �����$
��Bold"�6�   $��Times New Roman)�6�   $��Normal$�6�      Columns 5'      0  *System.Windows.Controls.DataGridTextColumn  5(      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã bệnh nhân��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *Mabn+  5)      $ 	Họ tên��6)    69   �� *Hoten+  5*      $ Mã Khoa��6)    6:   �� *Makhoa+  5+      $ Địa chỉ��6)    6:   �� *Diachi+  5,      $ Số ngày nằm viện��6)    6C   �� *
SongayNv+  5-      $ Viện Phí��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6W      	FontStyle$ Italic$�6a    6;   �� *	VienPhi+6a   5/      �� 50      -   5        $��btnthem��50      $��Thêm��6$   $
��Left=�63   $��100,500,0,0q�6N   $	��Top=�6c   $��75��6{   6�   �� 51      -	   5        $��btnsua��51      $��Sửa��6#   $
��Left=�61   $��250,500,0,0q�6L   $	��Top=�6a   $��75��6y   6�   �� 52      -
   5        $��btnxoa��52      $
��Xóa��6#   $
��Left=�61   $��400,500,0,0q�6L   $	��Top=�6a   $��75��6y   6�   �� 53      -   5        $��
btnthongke��53      $��Thống kê��6'   $
��Left=�6:   $��550,500,0,0q�6U   $	��Top=�6j   $��75��6�   6�   54      55      56      