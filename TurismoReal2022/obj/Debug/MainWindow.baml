   M S B A M L   `   `   `  ????J  FTurismoReal2022, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:TurismoReal2022TurismoReal2022  5   	   ?$clr-namespace:TurismoReal2022.VistasTurismoReal2022.Vistas  5   	        TurismoReal2022.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:TurismoReal2022     5   	   ;
viewmodels$clr-namespace:TurismoReal2022.Vistas     5   	   -   5          ? Title$  MenuPrincipal??5	   	   $	??550??6   $	??800??6,    ? WindowStyle$
 None=?5
   	    ? 
ResizeMode$ NoResize=?5   	    ? WindowStartupLocation$ CenterScreen=?5   	   
??????  ? AllowsTransparency .  ? 	Resources 5         FocusVisual ?? Property ?? Value ?? StrokeDashArray	 J? SnapsToDevicePixels  Button.Static.Background
 ?? Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 BtnShowHide ?? 
TargetType ?? 
TargetType ??Name ??Name ?? Triggers P? Property P? Value ?? 
TargetName  FocusVisual1  Button.Static.Background1  Button.Static.Border1   Button.MouseOver.Background1  Button.MouseOver.Border1  Button.Pressed.Background1  Button.Pressed.Border1  Button.Disabled.Background1  Button.Disabled.Border1  Button.Disabled.Foreground1  BtnListaStyle  FocusVisual2  Item.MouseOver.Background  Item.MouseOver.Border " Item.SelectedActive.Background  Item.SelectedActive.Border $  Item.SelectedInactive.Background   Item.SelectedInactive.Border  ListViewItemStyle ?? RelativeSource ?? AncestorType ?? Padding ]? 
Conditions ?? Property ?? Value ?? DataType%   TurismoReal2022.Vistas.Usuarios ? DataContext??%K  &	        &	 ?     &	 ?     &	 ?     &	     &	 6    &	 Y    &	 |    &	 ?    &		 ?    &	
 ?    7   7  7  7 	 &	 ?    &	 6    &	 Y    &	 |    &	 ?    &	 ?    &	 ?    &	     &	 +    &	 N    &	 q    7  7  7  7  7  7  &	 J    &	 ?    &	     &	 :    &	 ]    &	 ?    &	 ?    &	 ?    7  (?? ?    5?      *, +)?? 5   
   .?5      ??  ? ?? 5      ?? 5      .R?5      ?? $??2q?6$   $	 1 2R?6/   #??? ??6E   	 . $??1??6?   5      5      5      ?? 5   
   $
 	#FFDDDDDD??6;   ?? 5   
   $
 	#FF707070??67   ?? 5   
   $
 	#FFBEE6FD??6>   ?? 5   
   $
 	#FF3C7FB1??6:   ?? 5    
   $
 	#FFC4E5F6??6<   ?? 5!   
   $
 	#FF2C628B??68   ?? 5"   
   $
 	#FFF4F4F4??6=   ?? 5#   
   $
 	#FFADB2B5??69   ?? 5$   
   $
 	#FF838383??6=   ?? 5&   
   " d?6$   .?5'      ??  ?@?FocusVisualStyle8   61   ?? 5(       ? ??
 ???? 6+   ?? 5)       ? ??
 ???? 6,   ?? 5*       ? ??# ? ??6+   ?? 5+       ? ??$ 1q?60   ?? 5,       ? ??$ Center=?6;   ?? 5-       ? ??$ Center=?69   ?? 5.       ? ??$ 1q?6(   ?? 5/       ? ?? 50      ?? 51      " d?6&   .R?52      ?? $ border??6!   #??z??61   #??z??6[   #??z??6?   	 . ._?53      ?? $ contentPresenter??6/   |?.  #??z??6[   #??z??6?   ??. #	 z	 6?   #??z??6  54       55      P? 56       ?@??IsDefaulted . . ?57   "   ?? $ border??6@   # ? ??6T    ? ??58      P? 59       ? {? .  . ?5:   "   ?? $ border??6?   8   ? ??6S   ?? 5;   "   $ border??6@   8   ? ??6T   ?? 5<   "   $ contentPresenter??6K   8   ? ??6i   5=      5?      5A      5B      ?? 5D   
   .?5E      ??  ? ?? 5F      ?? 5G      .R?5H      ?? $??2q?6$   $	 1 2R?6/   #??? ??6E   	 . $??1??6?   5I      5K      5L      ?? 5N   
   $
 	#FFDDDDDD??6<   ?? 5O   
   $
 	#FF707070??68   ?? 5P   
   $
 	#FFBEE6FD??6?   ?? 5Q   
   $
 	#FF3C7FB1??6;   ?? 5R   
   $
 	#FFC4E5F6??6=   ?? 5S   
   $
 	#FF2C628B??69   ?? 5T   
   $
 	#FFF4F4F4??6>   ?? 5U   
   $
 	#FFADB2B5??6:   ?? 5V   
   $
 	#FF838383??6>   ?? 5W   
   " ??6&   .?5X      ??  ?@?FocusVisualStyle8   61   ?? 5Y       ? ??8  6+   ?? 5Z       ? ??8  6,   ?? 5[       ? ??# ? ??6+   ?? 5\       ? ??$ 1q?60   ?? 5]       ? ??$ Center=?6;   ?? 5^       ? ??$ Center=?69   ?? 5_       ? ??$ 1q?6(   ?? 5`       ? ?? 5a      ?? 5b      " ??6&   .R?5c      ?? $ border??6!   #??z??61   #??z??6[   #??z??6?   	 . ._?5d      ?? $ contentPresenter??6/   |?.  #??z??6[   #??z??6?   ??. #	 z	 6?   #??z??6  5e       5f      P? 5g       ?@??IsDefaulted . . ?5h   "   ?? $ border??6@   # ? ??6T    ? ??5i      P? 5j       ?@J?IsMouseOver . . ?5k   "   ?? $ border??6?    ? ??
 ???? 6S   ?? 5l   "   $ border??6@    ? ??
 ???? 6T   5m      P? 5n       ? ?? . . ?5o   "   ?? $ border??6?    ? ??
 ?????6S   ?? 5p   "   $ border??6@    ? ??
 ?????6T   5q      P? 5r       ? {? .  . ?5s   "   ?? $ border??6?   8   ? ??6S   ?? 5t   "   $ border??6@   8   ? ??6T   ?? 5u   "   $ contentPresenter??6K   8   ? ??6i   5v      5x      5z      5{      ?? 5~   
   .?5      ??  ? ?? 5?      ?? 5?      .R?5?      ?? $??2q?6$   $	 1 2R?6/   #??? ??6E   	 . $??1??6?   5?      5?      5?      ?? 5?   
   $
 	#1F26A0DA??6<   ?? 5?   
   $
 	#a826A0Da??68   ?? 5?   
   $
 	#3D26A0DA??6A   ?? 5?   
   $
 	#FF26A0DA??6=   ?? 5?   
   $
 	#3DDADADA??6C   ?? 5?   
   $
 	#FFDADADA??6?   ?? 5?   
   " ??6*   .?5?      ??  ?@J?SnapsToDevicePixels . 64   ?? 5?       ? ??$	 4,1q?6(   ?? 5?       ? ?? 6;   ?? *HorizontalContentAlignment+ ?? " ???? 5?       ? ?? 69   ?? *VerticalContentAlignment+ ?? " ???? 5?       ? ??
 ???? 6+   ?? 5?       ? ??
 ???? 6,   ?? 5?       ? ??$ 1q?60   ?? 5?       ?@?FocusVisualStyle8   61   ?? 5?       ? ?? 5?      ?? 5?      " ??6&   .R?5?      ?? $ Bd??6!   #??z??6-   #??z??6W   #??z??6?   # z??6?   	 . ._?5?      ?? #??z??6/   #	 z	 6r   #??z??6?   5?       5?      ]? 5?       5?   "   ?? 5?   &    ?@J?IsMouseOver . 6G   ./?5?   "   ?? $ Bd??6?    ? ??
 ?????6O   ?? 5?   "   $ Bd??6@    ? ??
 ?????6P   5?      P? 5?       ? {? .  . ?5?   "   ?? $ Bd??6K   # ? ??6[    ? ??5?      5?      5?      5?      ?? 5?   
   Usuarios??"  5?      .R?5?         6"   ?? 5?      5?      .??5?      ??  ?? CornerRadius$ 12??6   ??5?   
   ?? 5?       ?? ImageSource$ /Images/back-image.png??6   ._?5?   
   ?? $ 10??6   $??2q?5?       J? Opacity$
 0.97Q?5?      ??5?      ?? 5?       ?? EndPoint$	 1,0&?6&    ?? 
StartPoint$	 0,1&?65   .??5?      ?   ? Color$  	#FF2B1A16??6#   ! ? Offset$! 0Q?65   ? 5?      $  DimGray??6#   $! 1Q?63   5?      ??5?      ?? 5?      $	 0,0&?6&   $	 1,1&?67   .??5?      ? $	  red??6#   $! 1Q?6/   ? 5?      $  Maroon??6#   $! 0.498Q?62   5?      ._?5?      ? " ? ColumnDefinitions" 5?      ?? 5?      $
??639* ?6'   ?? 5?      $
??158* ?6'   # ? RowDefinitions# 5?      ?? 5?      $??30 ?6$   ?? 5?      .+?5?      ? $??0??6   $??2??6$   " 5?      ?? 5?      ?? 5?      $??25 ?6+   ?? 5?      $??25 ?6+   ?? 5?      $??5 ?6+   .+?5?      ?? $??Turismo Real APP ??6    
???????$??10(?5?       $??
Montserrat)?5?       $??0??5?       $??Center=?5?       $??10,0,0,0q?5?       ?? 5?      -   5        $ ??Name$$ btnMinimize??5?      $??0q?5?      $??-??5?      
???????$??16(?5?      $??
Montserrat)?5?      % ? Cursor$
% Hand??5?      $??1??5?      $
??Left=?5?   7   $??25??6R   ??5?      ?? 5?      " ??6$   .?5?   "   ??  ? ?? ?#28AEED6?   & ?? Triggers& 5?   "   P? 5?   &    ?@J?IsMouseOver . . ?5?   *   ??  ? ?? ?#278BEF6G   5?   '   5?      ??5     ?? 5     " ??6.   .R?5  "   ?? $??18??6)   $??18??64   $ 9??5  )   #??z??5  )   ._?5  &   ?? $??Center=?67   $??Center=?5  7   5	  #   5
     5     ?? 5     -   5        $$ btnClose??5     $??0q?5     $??X??5     
???????$??12(?5     $??
Montserrat)?5     $
% Hand??5     $??2??5     ??5     ?? 5     " ??6$   .?5  "   ??  ? ??
 ?  ??6?   & 5  "   P? 5  &    ?@J?IsMouseOver . . ?5  *   ??  ? ??
 ?? ??6G   5  '   5!     ??5$     ?? 5%     " ??6.   .R?5&  "   ?? $??18??6)   $??18??64   $ 9??5'  )   #??z??5(  )   ._?5)  &   ?? $??Center=?67   $??Center=?5*  7   5+  #   5,     5.     50     ? 53     -   5        ' ?Name$' GridContent??53     
?????? $??Bottom=?55     $??Right=?56     $	??511??57     $	??695??58     $??2??59     $??1??5:     $??0,5,25,0q?5;     # 5=     ?? 5>     $	??511 ?6(   ?? 5?     $	??200 ?6(   .+?5A     ?? $ 0,0,10,0??6   
???????$	 0.4Q?5C     $??-42,-5,-42,-249q?6+   $??2??6D   ?? 5E     $??Turismo Real??6    $??Center=?5F      $??Center=?5H      $??50(?5I      $??Times new Roman)?5J      ?? 5K     ??6%   ?? 5M     ? 5S     -   5        $' GridMenu??5S     
?????? $??75??5U     $
??Left=?5V     $??0,5,0,0q?5W     $??1??5X     # 5Y     ?? 5Z     $	??89* ?6(   ?? 5[     $
??225* ?6(   ?? 5\     $
??197* ?6(   .+?5^     ?? 
???  ??$ 0,0,0,10??5_     $??3??65   ?? 5a     
?????? $	??Top=?5b  !   $??3??69   .+?5d     ? 
?????? $	??Top=?5e     $??Right=?5f     $??	0,10,10,0q?5g     .+?5h     d? -   5        ( d?Name$( btnShowhide??5h  Q   #??? 
 6+   $??30??5i  +   $??30??5j  +   $
% Hand??5k  +   
?????? $	??Top=?5n  >   ??5o  "   ?? 5p  &   $ \Images\Hambur.png??61   ) ? Triggers) 5r  "   :? 5t  &   * :? RoutedEvent$* ToggleButton.Unchecked??63   .[?5u  *   ?? .??5v  .   ?? -   5        + ??Name$+ 	HidePanel??5v  9   .??5w  2   W? , ?? 
TargetName$, GridMenu??6B   - ?? TargetProperty$- Width?5x  B   . g? 	BeginTime$. 0:0:0X?5y  B   / W? From$	/ 200X?5z  B   	0 W? To$0 75X?6M   1 g? Duration$1 	0:0:0:0.5D?5{  B   5|  /   5}  +   5~  '   :? 5?  &   $* ToggleButton.Checked??63   .[?5?  *   ?? .??5?  .   ?? -   5        $+ 	ShowPanel??5?  9   .??5?  2   W? $, GridMenu??6B   $- Width?5?  B   $. 0:0:0X?5?  B   $/ 75X?5?  B   $	0 200X?6L   $1 	0:0:0:0.5D?5?  B   5?  /   5?  +   5?  '   5?     5?     ?? 5?     
?????? 
?????? $??
0,30,0,0  q?5?  #   $??Disabled=?5?  #   .@?5?     ?? #???  6+   $??70??6W   .??5?  "   ?? -	   5        $$ 	BtnInicio??5?  Q   #???  6)   $??70??5?  )   $	??200??5?  )   $
??Left=?5?  )   $
% Hand??5?  )   
?????? 
?????? .??5?  &   ? $	??200??6+   " 5?  *   ?? 5?  .   $??60 ?6?   ?? 5?  .   .+?5?  *   ?? $??50??60   $??0??5?  0   $??Center=?5?  0   $??\Images\Home.png??5?  0   ?? 5?  *   $??1??64   $??Inicio??5?  4   $
??Bold"?5?  4   $??15(?5?  4   $??Center=?5?  4   $??Center=?5?  4   5?  '   5?  #   5?     ?? 5?     #???  6+   $??70??6W   .??5?  "   ?? -
   5        $$ btnDepartamento??5?  Q   #???  6)   $??70??5?  )   $	??200??5?  )   $
??Left=?5?  )   $
% Hand??5?  )   
?????? 
?????? .??5?  &   ? $	??200??6+   " 5?  *   ?? 5?  .   $??60 ?6?   ?? 5?  .   .+?5?  *   ?? $??50??60   $??0??5?  0   $??Center=?5?  0   $??\Images\Dpto.png??5?  0   ?? 5?  *   $??1??64   $??Departamentos??5?  4   $
??Bold"?5?  4   $??15(?5?  4   $??Center=?5?  4   $??Center=?5?  4   5?  '   5?  #   5?     ?? 5?     #???  6+   $??70??6W   .??5?  "   ?? -   5        $$ btnAUsuario??5?  Q   #???  6)   $??70??5?  )   $	??200??5?  )   $
??Left=?5?  )   $
% Hand??5?  )   
?????? 
?????? .??5?  &   ? $	??200??6+   " 5?  *   ?? 5?  .   $??60 ?6?   ?? 5?  .   .+?5?  *   ?? $??50??60   $??0??5?  0   $??Center=?5?  0   $??\Images\Usuario.png??5?  0   ?? 5?  *   $??1??64   $??Usuarios??5?  4   $
??Bold"?5?  4   $??15(?5?  4   $??Center=?5?  4   $??Center=?5?  4   5?  '   5?  #   5?     ?? 5?     #???  6+   $??70??6W   .??5?  "   ?? -   5        $$ btnInventario??5?  )   #???  5?  )   $??70??5?  )   $	??200??5?  )   $
??Left=?5?  )   $
% Hand??5?  )   
?????? 
?????? .??5?  &   ? $	??200??6+   " 5?  *   ?? 5?  .   $??60 ?6?   ?? 5?  .   .+?5?  *   ?? $??50??60   $??0??5?  0   $??Center=?5   0   $??\Images\Inventario.png??5  0   ?? 5  *   $??1??64   $??
Inventario??5  4   $
??Bold"?5  4   $??15(?5  4   $??Center=?5  4   $??Center=?5  4   5	  '   5
  #   5     ?? 5     #???  6+   $??70??6W   .??5  "   ?? -   5        $$ btnMantenciones??5  )   #???  5  )   $??70??5  )   $	??200??5  )   $
??Left=?5  )   $
% Hand??5  )   
?????? 
?????? .??5  &   ? $	??200??6+   " 5  *   ?? 5  .   $??60 ?6?   ?? 5  .   .+?5  *   ?? $??50??60   $??0??5  0   $??Center=?5  0   $??\Images\Mantencion.png??5   0   ?? 5!  *   $??1??64   $??Mantenimiento??5"  4   $
??Bold"?5#  4   $??15(?5$  4   $??Center=?5%  4   $??Center=?5&  4   5(  '   5)  #   5*     ?? 5-     #???  6+   $??70??6W   .??5.  "   ?? -   5        $$ 
btnInforme??5.  Q   #???  6)   $??70??5/  )   $	??200??50  )   $
??Left=?51  )   $
% Hand??52  )   
?????? 
?????? .??55  &   ? $	??200??6+   " 56  *   ?? 57  .   $??60 ?6?   ?? 58  .   .+?5:  *   ?? $??50??60   $??0??5;  0   $??Center=?5<  0   $??\Images\Informe.png??5=  0   ?? 5>  *   $??1??64   $??Informes??5?  4   $
??Bold"?5@  4   $??15(?5A  4   $??Center=?5B  4   $??Center=?5C  4   5E  '   5F  #   5G     5J     5M     5P     5T     5V     5X     5Z     