   M S B A M L   `   `   `  ����J  FAssetManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:AssetManagement.UserControlAssetManagement.UserControl  5      8    2AssetManagement.UserControl.UCNotificationEmployee   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:AssetManagement.UserControl     5      .��5	      � .+�5
   
   �� $��	0,0,337,0q�6   ��5      �� 5        �� EndPoint$  0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FF00E8FF��6#    � Offset$ 0Q�65   � 5      $
 Blue��6#   $ 1Q�60   5      5      �� 5   
   $��Employee��6   $��Center=�6$   $	��Top=�6A   $��
38,3,373,0q�6Y   
���   �$��15(�6�   $��76��6�   �� 5   
   $���{C:\Users\vais\Documents\kerja\mii metrodata\DAILY TASK\dot net\Task Wpf\AssetManagement\AssetManagement\Asset\userlogin.png��6   $
��Auto��6�   $��63��6�   $	��Top=�6�   $��35,28,376,0q�6�   �� 5   
    �� Orientation$ Vertical=�6   $
��Left=�6,   $	��136��6G   $��
10,106,0,0q�6T   $	��Top=�6h   $	��129��6�   .+�5      �� .@�5      �� $��28��6   
����  �.��5      �� $ 
Horizontal=�6!   .+�5      �� $���{C:\Users\vais\Documents\kerja\mii metrodata\DAILY TASK\dot net\Task Wpf\AssetManagement\AssetManagement\Asset\dashboard.png��6    $
��Auto��6�   $��20��6�   $	��Top=�6�   �� 5      -   5         ��Name$ txt_Dasboard1��5   $   $��	Dashboard��6;   $��Center=�6L   $��3,0,0,0q�6g   5      5      �� 5      $��28��6   
����  �$��0,0,0,0q�6=   .��5      �� $ 
Horizontal=�6!   .+�5      �� $��yC:\Users\vais\Documents\kerja\mii metrodata\DAILY TASK\dot net\Task Wpf\AssetManagement\AssetManagement\Asset\loaning.png��6    $
��Auto��6�   $��20��6�   $	��Top=�6�   �� 5      -   5        $ txt_Loaning1��5   $   $��Loaning��6;   $��Center=�6J   $��3,0,0,0q�6e   5       5!      �� 5"      $��28��6   
����  �$��0,0,0,0q�6=   .��5#      �� $ 
Horizontal=�6!   .+�5$      �� $���zC:\Users\vais\Documents\kerja\mii metrodata\DAILY TASK\dot net\Task Wpf\AssetManagement\AssetManagement\Asset\Handover.png��6    $
��Auto��6�   $��20��6�   $	��Top=�6�   �� 5%      -   5        $ txt_Handover��5%   $   $��Handover��6:   $��Center=�6J   $��3,0,0,0q�6e   5&      5'      �� 5(      $��28��6   
����  �$��0,0,0,0q�6=   .��5)      �� $ 
Horizontal=�6!   .+�5*      �� $����C:\Users\vais\Documents\kerja\mii metrodata\DAILY TASK\dot net\Task Wpf\AssetManagement\AssetManagement\Asset\notifications-button.png��6    $
��Auto��6�   $��20��6�   $	��Top=�6�   �� 5+      -   5        $ 
txt_Notif1��5+   $   $��Notification��68   $��Center=�6L   $��3,0,0,0q�6g   5,      5-      5.      5/      �� 50   
   $��27��6   $��	158,0,0,0q�6    $	��Top=�63   ��51      �� 52      $  0.5,1&�6&   $ 0.5,0&�67   .��53      � $ 	#FF3426BA��6#   54      56      �� 57   
   -   5         ��Name$ lbl_NotificationEmployee��57      $��Notification��62   $
��Left=�6I   $��
155,-3,0,0q�6d   $	��Top=�6x   $��15(�6�   
�������6�   �� 58   
   -   5         ��Name$ 
btn_logout��58      $
��Left=�6%   $��	402,3,0,0q�6@   $	��Top=�6S   $��75��6k   $��20��6v   ��59      �� 5:      .R�5;      �� $ 
Horizontal=�6!   $
��Auto��6:   $
��Auto��6H   $��0,0,1,2q�6U   .+�5<      ��  ��Name$ image��6�   $��yC:\Users\vais\Documents\kerja\mii metrodata\DAILY TASK\dot net\Task Wpf\AssetManagement\AssetManagement\Asset\logout2.png��6    $��13��6�   $��5,4,0,0q�6�   $��Center=�6�   $
��Left=�6�   $��25��6  �� 5=      $ 
txt_Logout��6$   $
��Wrap=�68   $��Logout��6L   $��0,0,0,0q�6Z   $��12(�6k   ���	#FFF3F2F26y   5>      5?      5A      &   System.Windows.Controls.DataGrid  5B   
   -   5        	  Name$	 dataGrid_NotifEmployee��5B      $
��Left=�63   $��
158,28,0,0q�6N   $	��Top=�6b   $	��210��6z   $	��337��6�   
   Columns
 5C      0  *System.Windows.Controls.DataGridTextColumn  5D      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%     5E      $ 	Form Type��6%     5F      $ Status��6%     5G      $
 Date��6%   5I      �� 5J   
   -   5        $ btn_NotificationEdit��5J      $
��Edit��6R   $
��Left=�6a   $��324,261,0,0q�6|   $	��Top=�6�   $��75��6�   ���	#FF22D1326�   �� 5K   
   -	   5        $ btn_NotificationDelete��5K      $��Delete��6V   $
��Left=�6g   $��410,261,0,0q�6�   $	��Top=�6�   $��75��6�   ���	#FFD832326�   5L      5M      