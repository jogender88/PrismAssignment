   M S B A M L   `   `   `  ����X  TXceed.Wpf.Toolkit, Version=3.7.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4P:clr-namespace:Xceed.Wpf.Toolkit;assembly=Xceed.Wpf.ToolkitXceed.Wpf.Toolkit  5   	   O KAssignment.ViewModel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY@clr-namespace:Assignment.ViewModel;assembly=Assignment.ViewModelAssignment.ViewModel 5   	   J FAssignment.View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Assignment.View.PropertiesAssignment.View.Properties 5	   	      Assignment.View.Register   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Kxcts:clr-namespace:Xceed.Wpf.Toolkit;assembly=Xceed.Wpf.Toolkit     5   	   Ovm@clr-namespace:Assignment.ViewModel;assembly=Assignment.ViewModel     5   	   :local(clr-namespace:Assignment.View.Properties     5	   	     � Title$  
MainWindow��5
   	   $	��550��6   $	��800��6)      LayoutGridStyle#��[  65    � DataContext 5      0  *Assignment.ViewModel.RegistrationViewModel  5   
   .��5      � $��134,48,46,59q�6   .+�5   
   ��   Heading#��[ 6   $��35��65   $
��Left=�6A   )  #Assignment.View.Properties.Resource    UserRegistrationFormLabel#��Z 6\   $��	100,0,0,0q�6�   $	��Top=�6�   $	��300��6�   $��24(�6�   � 5   
   $	��325��6   $��Bottom=�6   $��	0,0,23,40q�67    � RowDefinitions 5      �� 5      .+�5      �� -   5        $��errormessage��5   s     errorMsg#��[ 6   $��20��6:   $
��Left=�6F   $��67,0,0,0q�6a   $	��Top=�6�   $	��368��6�    J� OpacityMask
 �<�����	#FFE5572C��6�   ��  �� Path$ ErrorMessage� �� Mode$ TwoWay=�6�   �� 5      -   5        $��textBlockFName��5   O     
LabelStyle#��[ 6   $��	67,20,0,0q�6<      FirstNameLabel#��Z 6e   �� 5      -   5        $��textBlockLName��5   O   #��[ 6   $��	67,45,0,0q�6<      LastNameLabel#��Z 6e   �� 5      -   5        $��textBlockEmailId��5   O   #��[ 6   $��	67,70,0,0q�6<   	   
EmailLabel#��Z	 6g   �� 5      -   5        $��textBlockGender��5   O   #��[ 6   $��	67,95,0,0q�6<   
   GenderLabel#��Z
 6f   �� 5      -   5        $��textBlockDOB��5   P   #��[ 6   $��
67,120,0,0q�6<      DOBLabel#��Z 6d   �� 5       -   5        $��textBlockPassword��5    P   #��[ 6   $��
67,145,0,0q�6<      PasswordLabel#��Z 6i   �� 5!      -   5        $��textBlockConfirmPwd��5!   P   #��[ 6   $��
67,170,0,0q�6<      ConfirmPasswordLabel#��Z 6k   �� 5#      -	   5        $��textBoxFName��5#   P     TextBoxStyle#��[ 6   $��
183,20,0,0q�6<    �� 	MaxLength$ 20��6d   ��6s   �� $ 	FirstName�$ TwoWay=��� 5$      -
   5        $��errorTextBlockFName��5$   M   #��[ 6   $��	67,20,0,0q�6:   ��6h   �� $ 
FNameError�$ TwoWay=��� 5&      -   5        $��textBoxLName��5&   P   #��[ 6   $��
183,45,0,0q�6<   $ 20��6d   ��6s   �� $ LastName�$ TwoWay=��� 5'      -   5        $��errorTextBlockLName��5'   M   #��[ 6   $��	67,45,0,0q�6:   ��6h   �� $ 
LNameError�$ TwoWay=��� 5)      -   5        $��textBoxEmail��5)   P   #��[ 6   $��
183,70,0,0q�6<   ��6d   �� $ EmailId�$ TwoWay=��� 5*      -   5        $��errorTextBlockEmailId��5*   M   #��[ 6   $��	67,70,0,0q�6:   ��6j   �� $ 
EmailError�$ TwoWay=�)   #Xceed.Wpf.Toolkit.WatermarkComboBox  5,      -   5        $��Gender��5,   �   $��20��6%      	Watermark$ Please Select Gender..��61   $
��Left=�6T   $��
183,95,0,0q�6o   $	��Top=�6�   $	��222��6�    �� DisplayMemberPath$ 
GenderType��5-   C    �� SelectedValuePath$ 
GenderType��5.      ��5-      �� $ GenderCategory� �� SelectedValue 5.   6   �� $ GenderValue.GenderType�$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem 6�   �� $ GenderValue�$ TwoWay=�5/      �� 50      -   5        $��errorTextBlockGender��50   M   #��[ 6   $��	67,95,0,0q�6:   ��6i   �� $ GenderError�$ TwoWay=�(  "System.Windows.Controls.DatePicker  52      -   5        $��DatePickerDOB��52   U   $��23��6   $
��Left=�6%   $��183,120,0,0q�6@   $	��Top=�6�   $	��222��6�      DisplayDate$ 
01/01/1980��6�      SelectedDate 6j   �� $	 DOB�$ PropertyChanged=� �� StringFormat$ 
dd.MM.yyyy��6�   �� 53      #��[ 6   $��
67,120,0,0q�6:   ��6N   �� $ DOBError�$ TwoWay=��� 56      -   5        $��password��56   o   #��[ 6   $��183,146,0,0q�6Z   $ 20��6�   ��6�   �� *
Password+�� 57      #��[ 6   $��
67,145,0,0q�6:   ��6N   �� $ PasswordError�$ TwoWay=��� 59      -   5        $��passwordConfirm��59   o   #��[ 6   $��183,170,0,0q�6Z   $ 20��6�   ��6�   �� *ConfirmPassword+�� 5:      #��[ 6   $��	7,170,0,0q�6:   ��6M   �� $ ConfirmPasswordError�$ TwoWay=��� 5=        	submitbtn#��[ 6   $��Submit��68   $��183,195,0,0q�6I   ��6^   �� *SubmitCommand+�� 5>      #��[ 6   $��Reset��68   $��259,195,0,0q�6H   ��6]   �� *ResetCommand+�� 5@      $��50��6   $
��Left=�6$   $��
67,220,0,0q�6?   $	��Top=�6T   $��12(�6l   $��Italic$�6z    �� Padding$ 5q�6�   �� 5A      %   RegisterWindowTextForLoginInfo#��Z 6    �� 5C      �� 5D      -   5        $��14(�5D   1   $��Normal$�6?   .�6R   Login6Y   5E      5G      5H      5I      5J      