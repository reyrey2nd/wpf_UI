   M S B A M L   `   `   `  ????C  ?ModernUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ModernUIModernUI  5   	       ModernUI.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:ModernUI     5   	     ? WindowStartupLocation$  CenterScreen=?5   	    ? WindowStyle$
 None=?5	   	    ? AllowsTransparency$
 True??5
   	   
?????? $	??500??5   	   $	??800??5   	   .??5      ?  ? ColumnDefinitions 5   
   ?? 5      $??* ?6   ?? 5      $
??1.5* ?6   .+?5   
   ?? -   5        $??/Images/close.png??5      $??1??6+    K? ZIndex$ 1??6;      imgClose#??[  6d   ?? 5   
    ?? CornerRadius$ 	10 0 0 10??6   ??5      ?? 5       ?? 
StartPoint$	 0,0&?6&    ?? EndPoint$	 1,1&?67   .??5      ?  ? Color$ #BFEEBD??6#   	 ? Offset$	 5Q?63   ? 5      $ #C5E8B7??6#   $	 5Q?63   5      ._?5      ? .+?5       ?? .+?5!      ? 
 ? Points'
 ?    ?? ?? ???? ??
?????#A8EBA66?   A? 5"      $??250 450 0 0q?6   $??40??63   $??40??6>   ???#BFEEBD6J   5$      ?? 5&      $??Center=?6   .+?5'      ?? $??Sign Up??6      	TitleText#??[ 6/   ?? 5(      $X??RLorem ipsum dolor sit amet, consectetur adipiscing elit. Nam faucibus dolor lorem.??6     J? Opacity$	 0.8Q?6z   $??20 30 20 30q?6?     
NormalText#??[ 6?   ?? 5)      -   5         ??Name$ button_SignUp??5)      $??Sign Up??64    
 button#??[ 6F   6f   5*      5+      5,      ?? 5.   
   -   5        ???#C5E8B7$??1??5.   &   $ 	0 10 10 0??66   ._?5/      ?? $??Center=?6   .+?50      ?? $??Ticketing System??6   ???#3AB19B#??[ 6I   ?? 53      ???#ACB0AF$??1q?6/   $??
70 30 70 0q?6C   $ 5??6W   ._?54      ? $	??7 9q?6    55      ?? 56      $
??auto ?6/   ?? 57      $??* ?6/   .+?5:      ?? $??/Images/Email.png??6    $??20??6;   ?? 5;      -   5         ??Name$ 	textEmail??5;   $   $??Username??5=   $     textHint#??[ 5>   $   ?? 5?      -   5        $??txtbox_Username??5?   "     textBox#??[ 5A   "   
?????? $??22??5C   "   5D      5E      ?? 5G      ???#ACB0AF$??1q?6/   $
??70 7q?6C   $ 5??6Q   ._?5H      ? $	??7 9q?6    5I      ?? 5J      $
??auto ?6/   ?? 5K      $??* ?6/   .+?5N      ?? $??/Images/Lock.png??6    $??20??6:   ?? 5O      -   5        $ textPassword??5O   $   $??Password??5Q   $   #??[ 5R   $   G? 5S      -   5         G?Name$ txtbox_Password??5S   &   #??[ 5U   &   
?????? $??22??5W   &   5X      5Y      ?? 5Z      -   5        $ button_Signin??5Z      $??Sign In??60     
mainButton#??[ 6W   5[      5\      5^      5_      