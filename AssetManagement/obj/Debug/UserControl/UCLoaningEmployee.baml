   M S B A M L   `   `   `  ����J  FAssetManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:AssetManagement.UserControlAssetManagement.UserControl  5      3    -AssetManagement.UserControl.UCLoaningEmployee   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:AssetManagement.UserControl     5      $	��300��5      $��495.113��6,   .��5      � .+�5	   
   �� $��	0,0,337,0q�6   ��5
      �� 5        �� EndPoint$  0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FF00E8FF��6#    � Offset$ 0Q�65   � 5      $
 Blue��6#   $ 1Q�60   5      5      �� 5   
   $��Employee��6   $��Center=�6$   $	��Top=�6A   $��
38,3,373,0q�6Y   
���   �$��15(�6�   $��76��6�   �� 5   
   $���{C:\Users\vais\Documents\kerja\mii metrodata\DAILY TASK\dot net\Task Wpf\AssetManagement\AssetManagement\Asset\userlogin.png��6   $
��Auto��6�   $��63��6�   $	��Top=�6�   $��35,28,376,0q�6�   �� 5   
    �� Orientation$ Vertical=�6   $
��Left=�6,   $	��136��6G   $��
10,106,0,0q�6T   $	��Top=�6h   $	��129��6�   .+�5      �� .@�5      �� $��28��6   
����  �.��5      �� $ 
Horizontal=�6!   .+�5      �� $���{C:\Users\vais\Documents\kerja\mii metrodata\DAILY TASK\dot net\Task Wpf\AssetManagement\AssetManagement\Asset\dashboard.png��6    $
��Auto��6�   $��20��6�   $	��Top=�6�   �� 5      -   5         ��Name$ txt_Dasboard1��5   $   $��	Dashboard��6;   $��Center=�6L   $��3,0,0,0q�6g   5      5      �� 5      $��28��6   
����  �$��0,0,0,0q�6=   .��5      �� $ 
Horizontal=�6!   .+�5      �� $��yC:\Users\vais\Documents\kerja\mii metrodata\DAILY TASK\dot net\Task Wpf\AssetManagement\AssetManagement\Asset\loaning.png��6    $
��Auto��6�   $��20��6�   $	��Top=�6�   �� 5      -   5        $ txt_Loaning1��5   $   $��Loaning��6;   $��Center=�6J   $��3,0,0,0q�6e   5      5       �� 5!      $��28��6   
����  �$��0,0,0,0q�6=   .��5"      �� $ 
Horizontal=�6!   .+�5#      �� $���zC:\Users\vais\Documents\kerja\mii metrodata\DAILY TASK\dot net\Task Wpf\AssetManagement\AssetManagement\Asset\Handover.png��6    $
��Auto��6�   $��20��6�   $	��Top=�6�   �� 5$      -   5        $ txt_Handover��5$   $   $��Handover��6:   $��Center=�6J   $��3,0,0,0q�6e   5%      5&      �� 5'      $��28��6   
����  �$��0,0,0,0q�6=   .��5(      �� $ 
Horizontal=�6!   .+�5)      �� $����C:\Users\vais\Documents\kerja\mii metrodata\DAILY TASK\dot net\Task Wpf\AssetManagement\AssetManagement\Asset\notifications-button.png��6    $
��Auto��6�   $��20��6�   $	��Top=�6�   �� 5*      -   5        $ 
txt_Notif1��5*   $   $��Notification��68   $��Center=�6L   $��3,0,0,0q�6g   5+      5,      5-      5.      �� 5/   
   $��27��6   $��	158,0,0,0q�6    $	��Top=�63   ��50      �� 51      $  0.5,1&�6&   $ 0.5,0&�67   .��52      � $ 	#FF3426BA��6#   53      55      �� 56   
   -   5         ��Name$ lbl_LoaningEmployee��56      $��Loaning��6-   $
��Left=�6?   $��
155,-3,0,0q�6Z   $	��Top=�6n   $��15(�6�   
�������6�   �� 57   
   -   5         ��Name$ 
btn_logout��57      $
��Left=�6>   $��	402,3,0,0q�6Y   $	��Top=�6l   $��75��6�   $��20��6�   ��58      �� 59      .R�5:      �� $ 
Horizontal=�6!   $
��Auto��6:   $
��Auto��6H   $��0,0,1,2q�6U   .+�5;      ��  ��Name$ image��6�   $��yC:\Users\vais\Documents\kerja\mii metrodata\DAILY TASK\dot net\Task Wpf\AssetManagement\AssetManagement\Asset\logout2.png��6    $��13��6�   $��5,4,0,0q�6�   $��Center=�6�   $
��Left=�6�   $��25��6  �� 5<      $ 
txt_Logout��6$   $
��Wrap=�68   $��Logout��6L   $��0,0,0,0q�6Z   $��12(�6k   ���	#FFF3F2F26y   5=      5>      5@      �� 5A   
   -   5        $ txt_LoaningId��5A      $
��Wrap=�6+   $��
Loaning Id��6?   $��164,32,258,248q�6Q   $��12(�6i   �� 5B   
   -   5        	 ��Name$	 txb_LoaningId��5B      
 �� TextWrapping$

 Wrap=�6)   $�� ��6=   $	��120��6E   $��252,32,123,249q�6Q   ��6�   Z� �� 5C   
   -	   5        $ txt_Date_Loaning��5C      $
��Wrap=�6.   $��Date Loaning��6B   $��164,58,258,222q�6V   $��12(�6n   (  "System.Windows.Controls.DatePicker  5D   
   -
   5          Name$ datePicker_DateLoaning��5D      $��252,56,123,223q�65   ��6M   Z� �� 5E   
   -   5        $ txt_Date_Loaning_Return��5E      $
��Wrap=�65   $��Date Return��6I   $��163,85,259,195q�6\   $��12(�6t     5F   
   -   5        $ datePicker_DateReturn��5F      $��252,82,123,197q�64   ��6L   Z� �� 5G   
   -   5        $ 
txt_ItemId��5G      $
��Wrap=�6(   $��Item Id��6<   $��163,110,259,170q�6K   $��12(�6d   �� 5H   
   -   5        $	 txb_SearchItemId��5H      $

 Wrap=�6,   $�� ��6@   $��252,108,175,173q�6H   ��6�   Z� �� 5I   
   -   5        $ btn_SearchItemId��5I      $��325,108,143,173q�6J   ��5J      �� 5K      .R�5L      �� $ 
img_search��6�   $~��xC:\Users\vais\Documents\kerja\mii metrodata\DAILY TASK\dot net\Task Wpf\AssetManagement\AssetManagement\Asset\search.png��6   $��13��6�   $��0,0,0,0q�6�   $��Center=�6�   $��25��6�   5M      5O      �� 5P   
   -   5        $ txt_NameItem��5P      $
��Wrap=�6*   $��	Name Item��6>   $��164,134,258,146q�6O   $��12(�6h   �� 5Q   
   -   5        $	 txb_NameItem��5Q      $

 Wrap=�6(   $�� ��6<   $	��120��6D   $��252,132,123,149q�6P   ��6�   Z� �� 5R   
   -   5        $ txt_Quantity��5R      $
��Wrap=�6*   $��Quantity��6>   $��164,157,258,123q�6N   $��12(�6g   �� 5S   
   -   5        $	 txb_Quantity��5S      $

 Wrap=�6(   $�� ��6<   $	��120��6D   $��252,156,123,125q�6P   ��6�   Z� �� 5T   
   -   5        $ btn_AddorEdit��5T      $��Add Or Edit��6D   $��75��6Z   $��397,157,23,121q�6e   ���	#FF1BF02E6}   �� 5U   
   -   5        $ 
btn_Delete��5U      $��Delete��6>   $��75��6O   $��397,190,23,88q�6Z   ���	#FFF0E61B6q   &   System.Windows.Controls.DataGrid  5V   
   -   5          Name$ dataGrid_Loaning��5V      $	��100��6-   $��164,190,115,10q�6:      Columns 5W      0  *System.Windows.Controls.DataGridTextColumn  5X      ,  &System.Windows.Controls.DataGridColumn   Header$ Item Id��6%     5Y      $ 	Name Item��6%     5Z      $ Quantity��6%   5\      �� 5]   
   -   5        $ btn_Send��5]      $
��Send��6:   $��75��6I   $��397,268,23,10q�6T   ���	#FF1414E46k   5^      5_      