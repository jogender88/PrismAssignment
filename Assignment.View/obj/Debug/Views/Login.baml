   M S B A M L   `   `   `  ����J  FAssignment.View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Assignment.View.PropertiesAssignment.View.Properties  5   	   O KAssignment.ViewModel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY@clr-namespace:Assignment.ViewModel;assembly=Assignment.ViewModelAssignment.ViewModel 5   	   !    Assignment.View.Views.Login   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:Assignment.View.Properties     5   	   Ovm@clr-namespace:Assignment.ViewModel;assembly=Assignment.ViewModel     5   	   -   5          � Title$  Login��5
   	   $	��450��6   $	��800��6$      LoginGridStyle#��[  60    � DataContext 5      )  #Assignment.ViewModel.LoginViewModel  5   
   .��5      � $	��350��6   $��Bottom=�6   $��Center=�63   $��
157,0,-8,0q�6P   $	��643��6d    � RowDefinitions 5   
   �� 5      .+�5   
   �� -   5        $��LoginHeading��5   o     Heading#��[ 6   $��23��65   $
��Left=�6A   $��	10,10,0,0q�6\   $��Login:��6�   $	��Top=�6�   $��17(�6�   $��ExtraCondensed&�6�   �� 5   
   -   5        $��textBlockHeading��5   O   $��50��6   $
��Left=�6!   $��	24,48,0,0q�6<   $	��Top=�6g   $��12(�6   $��Italic$�6�    �� Padding$ 5q�6�   ][Note: Please login here to view the features of this site. If you are new on this site then�� 5   j   please click on �� 5      �� 5      -   5        $��14(�5   :   $��Normal$�6H   .�6[   
Register6e   5      	 button5      �� 5   
   -   5        $��
EmailLabel��5   9     
LabelStyle#��[ 6   )   #Assignment.View.Properties.Resource   
EmailLabel#��Z 6K   $��
66,120,0,0q�6w   �� 5   
   -   5        $��PasswordLabel��5   8   #��[ 6      PasswordLabel#��Z 6M   $��
58,168,0,0q�6|   �� 5!   
   -   5        $��EmailTextBox��5!   8     TextBoxStyle#��[ 6   $��118,115,0,0q�6h   ��6L   ��  �� Path$ Email�6h   �� 5"   
   -   5        $��EmailErrorLabel��5"   6     errorMsg#��[ 6   $��0,115,120,0q�6n   ��6M   �� $ 
EmailError�6n   �� 5$   
   -	   5        $��PasswordTextBox��5$   8   #��[ 6   $��118,168,0,0q�6n   ��6O   �� $ Password�6n   �� 5%   
   -
   5        $��PasswordError��5%   6   #��[ 6   $��0,168,120,0q�6o   ��6K   �� $ PasswordError�6o   �� 5'   
   -   5        $��Loginl��5'   Y     	submitbtn#��[ 6   $��Login��64   $��118,211,0,0q�6D   ��6g   �� *LoginCommand+�� 5(   
   $��50��6   $
��Left=�6    $��118,38,10,60q�6;   $��Bottom=�6Q   $��12(�6l   $��Italic$�6z   $ 5q�6�   �� 5*      �� 5+      $��14(�6G   $��Normal$�6U    �� Command 6   �� *ForgotPasswordCommand+.�6h   Forgot Password6y   5,      5.      �� 5/   
   -   5         ��Name$ errormessage��5/   ;   $��23��6   $
��Left=�6    $��Bottom=�6R   $	��247��6�   $��118,23,0,50q�6�   
���  ����6m   �� $ ErrorMessage�6�   50      51      