   M S B A M L   `   `   `  ����J  FAssignment.View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Assignment.View.ViewsAssignment.View.Views  5   	   O KAssignment.ViewModel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY@clr-namespace:Assignment.ViewModel;assembly=Assignment.ViewModelAssignment.ViewModel 5   	        Assignment.View.Views.Home   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:Assignment.View.Views     5   	   Ovm@clr-namespace:Assignment.ViewModel;assembly=Assignment.ViewModel     5   	     � Title$
  Home��5	   	   $	��450��6   $	��800��6#      HomeGridStyle#��[  6/    � DataContext 5
      (  "Assignment.ViewModel.HomeViewModel  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��2* �6   .+�5   
   � $��0��6   .+�5      �� -   5         ��Name$ WelcomeHeading��5   U   $��23��6   $��Right=�6$   $��10,10,100,0q�6@   $��Welcome to the DashBoard:��6m   $	��Top=�6�   $��17(�6�   $��ExtraCondensed&�6�   �� 5      -   5        $ textBlockName��5   R   $��23��6   $
��Left=�6$   $��	90,10,0,0q�6?   $	��Top=�6�   $��15(�6�   $��ExtraCondensed&�6�   ��6i   ��  �� Path$
 Name� �� Mode$ TwoWay=�6�   �� 5      -   5         ��Name$ Logout��5      $��Logout��6%   $��
10,12,10,0q�6K   $��Right=�6_   $	��Top=�6{   $��80��6�   �� 5        errorMsg#��[ 6   $��23��6:   $��Center=�6F   $��0,0,0,28q�6c   $��Bottom=�6�   $��15(�6�   $��ExtraCondensed&�6�   ��6u   �� $ ErrorMessage�$ TwoWay=�6�   �� 5      $��23��6   $
��Left=�6$   $��	200,0,0,8q�6?   $��Search User��6R   $��Bottom=�6e   $��15(�6�   $��ExtraCondensed&�6�   �� 5      $	��200��6C   $��Center=�6O   $��Bottom=�6l   $��0,0,0,10q�6�   ��6   �� $ 
SearchText�$ TwoWay=�6�   �� 5      $��Search��6   $��Right=�6H   $��Bottom=�6d   $��	0,0,190,8q�6   $	��100��6�   ��6&   �� *SearchCommand+6�   �� 5      $��Reset��6   $��Right=�6F   $��Bottom=�6b   $��0,0,80,8q�6}   $	��100��6�   ��6%   �� *ResetCommand+6�   5      � 5   
   $��1��6   $��Center=�6   $	��Top=�69   .+�5       &   System.Windows.Controls.DataGrid     CanUserAddRows .     AutoGenerateColumns .  $��20q�6�   ��6   �� *
AllUsers+	 �� UpdateSourceTrigger$	 Default=�
   Columns
 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6@      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   �� *Id+6L     5#      $ 
First Name��6G   $
 Auto 6[    6)   �� *	FirstName+6[     5$      $ 	Last Name��6F   $
 Auto 6Y    6)   �� *
LastName+6Y     5%      $ Email��6E   $
 Auto 6T    6)   �� *	EmailId+6T     5&      $ Gender��6D   $
 Auto 6T    6)   �� *Gender+6T     5'      $ Date of Birth��6A   $
 Auto 6X    6)   �� *Dob+6X   5)      5*      5+      5-      