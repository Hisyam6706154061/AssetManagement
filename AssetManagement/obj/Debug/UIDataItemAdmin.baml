   M S B A M L   `   `   `  ����J  FAssetManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:AssetManagementAssetManagement  5      %    AssetManagement.UIDataItemAdmin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:AssetManagement     5      .��5	      � .+�5
   
   �� $��	0,0,450,0q�6   ��5      �� 5        �� EndPoint$  0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FF00E8FF��6#    � Offset$ 0Q�65   � 5      $
 Blue��6#   $ 1Q�60   5      5      �� 5   
   $��Admin��6   $��Center=�6!   $	��Top=�6>   $��
64,3,460,0q�6V   
���   �$��15(�6}   $��76��6�   �� 5   
   $���{C:\Users\vais\Documents\kerja\mii metrodata\DAILY TASK\dot net\Task Wpf\AssetManagement\AssetManagement\Asset\userlogin.png��6   $
��Auto��6�   $��63��6�   $	��Top=�6�   $��-13,25,424,0q�6�   �� 5   
    �� Orientation$ Vertical=�6   $
��Left=�6,   $	��136��6G   $��
10,106,0,0q�6T   $	��Top=�6h   $	��129��6�   .+�5      �� .@�5      �� $��28��6   
����  �.��5      �� $ 
Horizontal=�6!   .+�5      �� $���{C:\Users\vais\Documents\kerja\mii metrodata\DAILY TASK\dot net\Task Wpf\AssetManagement\AssetManagement\Asset\dashboard.png��6    $
��Auto��6�   $��20��6�   $	��Top=�6�   �� 5      -   5         ��Name$ txt_DashboardAdmin��5   $   $��	Dashboard��6@   $��Center=�6Q   $��3,0,0,0q�6l   5      5      �� 5      $��28��6   
����  �$��0,0,0,0q�6=   .��5      �� $ 
Horizontal=�6!   .+�5      �� $���zC:\Users\vais\Documents\kerja\mii metrodata\DAILY TASK\dot net\Task Wpf\AssetManagement\AssetManagement\Asset\database.png��6    $
��Auto��6�   $��20��6�   $	��Top=�6�   �� 5      -   5        $ txt_DataItem��5   $   $��	Data Item��6;   $��Center=�6L   $��3,0,0,0q�6g   5       5!      �� 5"      $��28��6   
����  �$��0,0,0,0q�6=   .��5#      �� $ 
Horizontal=�6!   .+�5$      �� $����C:\Users\vais\Documents\kerja\mii metrodata\DAILY TASK\dot net\Task Wpf\AssetManagement\AssetManagement\Asset\bookmark-black-shape.png��6    $
��Auto��6�   $��20��6�   $	��Top=�6�   �� 5%      -   5        $ txt_Procurement��5%   $   $��Procurement��6=   $��Center=�6P   $��3,0,0,0q�6k   5&      5'      �� 5(      $��28��6   
����  �$��0,0,0,0q�6=   .��5)      �� $ 
Horizontal=�6!   .+�5*      �� $����C:\Users\vais\Documents\kerja\mii metrodata\DAILY TASK\dot net\Task Wpf\AssetManagement\AssetManagement\Asset\notifications-button.png��6    $
��Auto��6�   $��20��6�   $	��Top=�6�   �� 5+      -   5        $ txt_NotifAdmin��5+   $   $��Notification��6<   $��Center=�6P   $��3,0,0,0q�6k   5,      5-      5.      5/      �� 50   
   $��27��6   $��	150,0,0,0q�6    $	��Top=�63   ��51      �� 52      $  0.5,1&�6&   $ 0.5,0&�67   .��53      � $ 	#FF3426BA��6#   54      56      �� 57   
   -   5         ��Name$ lbl_DataItemAdmin��57      $��	Data Item��6+   $
��Left=�6?   $��
155,-3,0,0q�6Z   $	��Top=�6n   $��15(�6�   
�������6�   �� 58   
   -   5         ��Name$ button��58      $
��Left=�6!   $��	502,5,0,0q�6<   $	��Top=�6O   $��75��6g   $��20��6r   ��59      �� 5:      .R�5;      �� $ 
Horizontal=�6!   $
��Auto��6:   $
��Auto��6H   $��0,0,1,2q�6U   .+�5<      ��  ��Name$ image��6�   $��yC:\Users\vais\Documents\kerja\mii metrodata\DAILY TASK\dot net\Task Wpf\AssetManagement\AssetManagement\Asset\logout2.png��6    $��13��6�   $��5,4,0,0q�6�   $��Center=�6�   $
��Left=�6�   $��25��6  �� 5=      $ 
txt_Logout��6$   $
��Wrap=�68   $��Logout��6L   $��0,0,0,0q�6Z   $��12(�6k   ���	#FFF3F2F26y   5>      5?      5A      &   System.Windows.Controls.DataGrid  5B   
   -   5        	  Name$	 dataGrid��5B      $
��Left=�6%   $��
150,27,0,0q�6@   $	��Top=�6T   $	��215��6l   $	��450��6y   
   Columns
 5C      0  *System.Windows.Controls.DataGridTextColumn  5D      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%     5E      $ 	Name Item��6%     5F      $ Category��6%     5G      $ Brand��6%     5H      $ Description��6%     5I      $ 	Condition��6%     5J      $ Stock��6%     5K      $ Price��6%   5M      �� 5N   
   -   5        $ btn_EditDataItemAdmin��5N      $
��Edit��60   $
��Left=�6?   $��470,257,0,0q�6Z   $	��Top=�6o   $��75��6�   ���	#FFE8D4106�   5O      5P      