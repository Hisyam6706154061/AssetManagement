   M S B A M L   `   `   `  ����J  FAssetManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:AssetManagement.UserControlAssetManagement.UserControl  5      4    .AssetManagement.UserControl.UCHandoverEmployee   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:AssetManagement.UserControl     5      .��5	      � .+�5
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
   -   5         ��Name$ lbl_HandoverEmployee��57      $��Handover��6.   $
��Left=�6A   $��
155,-3,0,0q�6\   $	��Top=�6p   $��15(�6�   
�������6�   �� 58   
   -   5         ��Name$ 
btn_logout��58      $
��Left=�6%   $��	402,3,0,0q�6@   $	��Top=�6S   $��75��6k   $��20��6v   ��59      �� 5:      .R�5;      �� $ 
Horizontal=�6!   $
��Auto��6:   $
��Auto��6H   $��0,0,1,2q�6U   .+�5<      ��  ��Name$ image��6�   $��yC:\Users\vais\Documents\kerja\mii metrodata\DAILY TASK\dot net\Task Wpf\AssetManagement\AssetManagement\Asset\logout2.png��6    $��13��6�   $��5,4,0,0q�6�   $��Center=�6�   $
��Left=�6�   $��25��6  �� 5=      $ 
txt_Logout��6$   $
��Wrap=�68   $��Logout��6L   $��0,0,0,0q�6Z   $��12(�6k   ���	#FFF3F2F26y   5>      5?      5A      �� 5B   
   -   5        $ txt_HandoverId��5B      $
��Wrap=�6,   $��Handover Id��6@   $��164,32,258,248q�6S   $��12(�6k   �� 5C   
   -   5        	 ��Name$	 txb_HandoverId��5C      
 �� TextWrapping$

 Wrap=�6*   $�� ��6>   $	��120��6F   $��252,32,123,249q�6R   ��6�   Z� �� 5D   
   -	   5        $ txt_Date��5D      $
��Wrap=�6&   $
��Date��6:   $��164,58,258,222q�6F   $��12(�6^   (  "System.Windows.Controls.DatePicker  5E   
   $��252,56,123,223q�6   ��6-   Z� �� 5F   
   -
   5        $ txt_HandoverLoaningId��5F      $
��Wrap=�63   $��
Loaning Id��6G   $��163,87,259,193q�6Y   $��12(�6q   �� 5G   
   -   5        $	 txb_HandoverLoaningId��5G      $

 Wrap=�61   $�� ��6E   $��252,85,175,196q�6M   ��6�   Z� �� 5H   
   -   5        $ btn_SearchLoaningId��5H      $��326,86,142,195q�6.   ��5I      �� 5J      .R�5K      �� $ 
img_search��6�   $~��xC:\Users\vais\Documents\kerja\mii metrodata\DAILY TASK\dot net\Task Wpf\AssetManagement\AssetManagement\Asset\search.png��6   $��13��6�   $��0,0,0,0q�6�   $��Center=�6�   $��25��6�   5L      5N      �� 5P   
   -   5        $ txt_HandoverUserId��5P      $
��Wrap=�60   $��User Id��6D   $��164,143,258,137q�6S   $��12(�6l   �� 5Q   
   -   5        $	 txb_HandoverUserId��5Q      $

 Wrap=�6.   $�� ��6B   $��252,138,175,143q�6J   ��6�   Z� �� 5R   
   -   5        $ txt_HandoverNameUser��5R      $
��Wrap=�62   $��	Name User��6F   $��326,140,96,140q�6W   $��12(�6o   �� 5S   
   -   5        $	 txb_HandoverNameUser��5S      $

 Wrap=�60   $�� ��6D   $��391,138,3,143q�6L   ��6�   Z� �� 5T   
   -   5        $ txt_HandoverItemId��5T      $
��Wrap=�60   $��Name Id��6D   $��164,167,258,113q�6S   $��12(�6l   �� 5U   
   -   5        $	 txb_HandoverItemId��5U      $

 Wrap=�6.   $�� ��6B   $��252,165,175,116q�6J   ��6�   Z� �� 5V   
   -   5        $ txt_HandoverNameItem��5V      $
��Wrap=�62   $��	Name Item��6F   $��326,167,96,113q�6W   $��12(�6o   �� 5W   
   -   5        $	 txb_HandoverNameItem��5W      $

 Wrap=�60   $�� ��6D   $��391,165,3,116q�6L   ��6�   Z� �� 5X   
   -   5        $ txt_Description��5X      $
��Wrap=�6-   $��Description��6A   $��163,205,259,75q�6T   $��12(�6l   �� 5Y   
   -   5        $	 txb_NameItem_Copy��5Y      $

 Wrap=�6-   $�� ��6A   $��251,196,14,44q�6I   ��6�   Z� �� 5Z   
   -   5        $ btn_Send��5Z      $
��Send��6#   $��75��62   $��391,261,29,7q�6=   ���	#FF1414E46j   5[      5\      