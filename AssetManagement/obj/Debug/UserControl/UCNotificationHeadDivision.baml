   M S B A M L   `   `   `  ����J  FAssetManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:AssetManagement.UserControlAssetManagement.UserControl  5      <    6AssetManagement.UserControl.UCNotificationHeadDivision   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:AssetManagement.UserControl     5      .��5	      � .+�5
   
   �� $��	0,0,337,0q�6   ��5      �� 5        �� EndPoint$  0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FF00E8FF��6#    � Offset$ 0Q�65   � 5      $
 Blue��6#   $ 1Q�60   5      5      �� 5   
   $��Head Division��6   $��Center=�6)   $	��Top=�6F   $��
35,5,360,0q�6^   
���   �$��15(�6�   $	��100��6�   �� 5   
   $���{C:\Users\vais\Documents\kerja\mii metrodata\DAILY TASK\dot net\Task Wpf\AssetManagement\AssetManagement\Asset\userlogin.png��6   $
��Auto��6�   $��63��6�   $	��Top=�6�   $��35,28,376,0q�6�   �� 5   
    �� Orientation$ Vertical=�6   $
��Left=�6,   $	��136��6G   $��
10,106,0,0q�6T   $	��Top=�6h   $	��129��6�   .+�5      �� .@�5      �� $��28��6   
����  �.��5      �� $ 
Horizontal=�6!   .+�5      �� $���{C:\Users\vais\Documents\kerja\mii metrodata\DAILY TASK\dot net\Task Wpf\AssetManagement\AssetManagement\Asset\dashboard.png��6    $
��Auto��6�   $��20��6�   $	��Top=�6�   �� 5      -   5         ��Name$ txt_DashboardHeadDivision��5   $   $��	Dashboard��6G   $��Center=�6X   $��3,0,0,0q�6s   5      5      �� 5      $��28��6   
����  �$��0,0,0,0q�6=   .��5      �� $ 
Horizontal=�6!   .+�5      �� $����C:\Users\vais\Documents\kerja\mii metrodata\DAILY TASK\dot net\Task Wpf\AssetManagement\AssetManagement\Asset\notifications-button.png��6    $
��Auto��6�   $��20��6�   $	��Top=�6�   �� 5      -   5        $ txt_NotifHeadDivision��5   $   $��Notification��6C   $��Center=�6W   $��3,0,0,0q�6r   5       5!      5"      5#      �� 5$   
   $��27��6   $��	158,0,0,0q�6    $	��Top=�63   ��5%      �� 5&      $  0.5,1&�6&   $ 0.5,0&�67   .��5'      � $ 	#FF3426BA��6#   5(      5*      �� 5+   
   -   5         ��Name$ lbl_DashboardAdmin��5+      $��	Dashboard��6,   $
��Left=�6@   $��
155,-3,0,0q�6[   $	��Top=�6o   $��15(�6�   
�������6�   �� 5,   
   -   5         ��Name$ 
btn_logout��5,      $
��Left=�6>   $��	402,3,0,0q�6Y   $	��Top=�6l   $��75��6�   $��20��6�   ��5-      �� 5.      .R�5/      �� $ 
Horizontal=�6!   $
��Auto��6:   $
��Auto��6H   $��0,0,1,2q�6U   .+�50      ��  ��Name$ image��6�   $��yC:\Users\vais\Documents\kerja\mii metrodata\DAILY TASK\dot net\Task Wpf\AssetManagement\AssetManagement\Asset\logout2.png��6    $��13��6�   $��5,4,0,0q�6�   $��Center=�6�   $
��Left=�6�   $��25��6  �� 51      $ 
txt_Logout��6$   $
��Wrap=�68   $��Logout��6L   $��0,0,0,0q�6Z   $��12(�6k   ���	#FFF3F2F26y   52      53      55      &   System.Windows.Controls.DataGrid  56   
   -   5        	  Name$	 dataGrid_NotificationHD��56      $
��Left=�64   $��
158,27,0,0q�6O   $	��Top=�6c   $	��202��6{   $	��337��6�   
   Columns
 57      0  *System.Windows.Controls.DataGridTextColumn  58      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%     59      $ 	Form Type��6%     5:      $ Status��6%     5;      $
 Date��6%   5=      �� 5>   
   -   5        $ btn_NotificationHDApprove��5>      $��Approve��6\   $
��Left=�6n   $��324,261,0,0q�6�   $	��Top=�6�   $��75��6�   ���	#FF22D1326�   �� 5?   
   -   5        $ btn_NotificationHDReject��5?      $��Reject��6Z   $
��Left=�6k   $��410,261,0,0q�6�   $	��Top=�6�   $��75��6�   ���	#FFD832326�   5@      5A      