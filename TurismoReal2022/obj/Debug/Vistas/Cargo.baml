   M S B A M L   `   `   `  ????J  FTurismoReal2022, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:TurismoReal2022.VistasTurismoReal2022.Vistas  5      "    TurismoReal2022.Vistas.Cargo   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:TurismoReal2022.Vistas     5      $	??509??5      $	??693??5	      
??????   ? 	Resources  5         TextBox.Static.Border ?? Color  TextBox.MouseOver.Border  TextBox.Focus.Border  TextBoxStyle ?? 
TargetType ?? Property ?? Value-  'System.Windows.Input.KeyboardNavigation ?? 
TargetType ??Name ?? CornerRadius J? SnapsToDevicePixels	 ??Name
 ?? Triggers P? Property P? Value ?? 
TargetName ?? Triggers ]? 
Conditions ?? Property ?? Value  FocusVisual ?? StrokeDashArray  Button.Static.Background  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border 	 Button.Pressed.Background 
 Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border  Button.Disabled.Foreground  ButtonBUSCAR ??Name ?? 
ResourceId ?? TypeInTargetAssembly&   System.Windows.Controls.DataGrid ??Name ?Name J? Opacity ? Points ?? Stretch  DataGridStyle ?? Padding ? ColumnDefinitions ? RowDefinitions   SelectAllCommand7  1System.Windows.Controls.DataGridHeadersVisibility
   All  ?? ConverterParameter!!   HeadersVisibilityConverter" ?? 	Converter# ?? RelativeSource$ ?? AncestorTypeG  ASystem.Windows.Controls.Primitives.DataGridColumnHeadersPresenter%  Name&   Column' ??Name( ?? CanContentScroll) ??Name* ?? ScrollableHeight+ ? Maximum, ?? Orientation- ?? ViewportHeight. ?? ViewportSize*/ ?? #ComputedVerticalScrollBarVisibility0 ? Value1 ?? Mode2 ?? ScrollableWidth3 ?? ViewportWidth,4 ?? %ComputedHorizontalScrollBarVisibility=  7System.Windows.Controls.Primitives.DataGridColumnHeader*  $System.Windows.Controls.DataGridCell??%?  &	        &	 #     &	 F     &	 i     7   7  7  &	 o    &	     &	 <    &	 _    &	 ?    &		 ?    &	
 ?    &	 ?    &	     &	 1    &	 T    7  7  7  7  7  7  (?? ;    5s      $" DataGridSelectAllButtonStyle??"  )&	 ?    '  L    '  2    ?? 5   
   $ 	#FFABAdB3??68   ?? 5   
   $ 	#FF7EB4EA??6;   ?? 5   
   $ 	#FF569DE5??67   ?? 5   
   " ??6%   .?5      ??  ? ??# ? ??6+   ?? 5       ? ??8   6,   ?? 5       ? ??# ? ??6+   ?? 5       ? ??$ 1q?60   ?? 5       ?@ TabNavigation$
 None=?6A   ?? 5       ? ??$
 Left=?6;   ?? 5       ?@?FocusVisualStyle 61   Z? ?? 5       ?@J?	AllowDrop . 6*   ?? 5       ?@??PanningMode$ VerticalFirst=?69   ?? 5       ?@??IsFlicksEnabled .  67   ?? 5       ? ?? 5      ?? 5      " ??6&   .R?5      ?? $ border??63   $ 10??6!   #??z??6C   #??z??6m   #??z??6?    . ._?5       ?? $	 PART_ContentHost??6+   |?.  $??Hidden=?6W   $??Hidden=?6~   5!      
 5"      P? 5#       ? {? .  . ?5$   "   ?? $ border??6<    ?@J?Opacity$
 0.56Q?6P   5%      P? 5&       ?@J?IsMouseOver . . ?5'   "   ?? $ border??6@   8   ? ??6T   5(      P? 5)       ?@J?IsKeyboardFocused . . ?5*   "   ?? $ border??6@   8   ? ??6T   5+      5-      5/       50      ]? 51       52      ?? 53      + ?@??#IsInactiveSelectionHighlightEnabled . 6S   ?? 54       ?@??IsSelectionActive .  6A   ./?56      ??  ?@??SelectionBrush# ? /?67   57      59      ?? 5:   
   .?5;      ??  ? ?? 5<      ?? 5=      .R?5>      ?? $??2q?6$   $	 1 2R?6/   #??? ??6E    . $??1??6?   5?      5A      5B      ?? 5E   
   $ 	#FFDDDDDD??6;   ?? 5F   
   $ 	#FF707070??67   ?? 5G   
   $ 	#FFBEE6FD??6>   ?? 5H   
   $ 	#FF3C7FB1??6:   ?? 5I   
   $ 	#FFC4E5F6??6<   ?? 5J   
   $ 	#FF2C628B??68   ?? 5K   
   $ 	#FFF4F4F4??6=   ?? 5L   
   $ 	#FFADB2B5??69   ?? 5M   
   $ 	#FF838383??6=   ?? 5N   
   " ??6%   .?5O      ??  ?@?FocusVisualStyle8   61   ?? 5P       ? ??8  6+   ?? 5Q       ? ??8  6,   ?? 5R       ? ??# ? ??6+   ?? 5S       ? ??$ 1q?60   ?? 5T       ? ??$ Center=?6;   ?? 5U       ? ??$ Center=?69   ?? 5V       ? ??$ 1q?6(   ?? 5W       ? ?? 5X      ?? 5Y      " ??6&   .R?5Z      ?? $ border??63   $ 10??6!   #??z??6C   #??z??6m   #??z??6?    . ._?5[      ?? $ contentPresenter??6/   |?.  #??z??6[   #??z??6?   ??. # z 6?   #??z??6  5\      
 5]      P? 5^       ?@??IsDefaulted . . ?5_   "   ?? $ border??6@   # ? ??6T    ? ??5`      P? 5a       ?@J?IsMouseOver . . ?5b   "   ?? $ border??6?    ? ??
 ?  ??6S   ?? 5c   "   $ border??6@    ? ??
 ?  ??6T   5d      P? 5e       ? ?? . . ?5f   "   ?? $ border??6?    ? ??
 ?  ??6S   ?? 5g   "   $ border??6@    ? ??
 ?  ??6T   5h      P? 5i       ? {? .  . ?5j   "   ?? $ border??6?   8   ? ??6S   ?? 5k   "   $ border??6@   8   ? ??6T   ?? 5l   "   $ contentPresenter??6K   8   ? ??6i   5m      5o      5q      5r      ?? 5s   
   " ??6   .?5t      ??  ? ?? 5u      ?? 5v      " ??6&   .R?5w      ? .+?5x      ?? $ Border??6(   #??? ??68    . 6y   ? 5y      $ Arrow??6&   
???   ?$??Right=?6B   $??8,8,3,3q?6^   $
 0.15Q?6o    ?   ??? ??? ??? ??? $ Uniform=?6?   $??Bottom=?6?   5z      
 5{      P? 5|       ?@J?IsMouseOver . . ?5}   "   ?? $ Border??6;   # ? ??6O    ? ??5~      P? 5       ? ?? . . ?5?   "   ?? $ Border??69   # ? ??6M    ? ??5?      P? 5?       ? {? .  . ?5?   "   ?? $ Arrow??6?    ? y?$ 	Collapsed=?6R   5?      5?      5?      5?      ?? 5?   
   "  6&   .?5?      ??  ? ??# ? ??6+   ?? 5?       ? ??# ? ??6+   ?? 5?       ? ?? ?	#FF688CAF6,   ?? 5?       ? ??$ 1q?60   ?? 5?        ?@ RowDetailsVisibilityMode$ VisibleWhenSelected=?69   ?? 5?       ? ?? . 6>   ?? 5?       ?@??PanningMode$
 Both=?69   ?? 5?       ?@??IsFlicksEnabled .  67   ?? 5?       ? ?? 5?      ?? 5?      "  6&   .R?5?      ?? $ 	0,0,10,10??6!   #??z??6:   #??z??6d   #??z??6?   # z??6?    . ._?5?      ?? $	 DG_ScrollViewer??6+   |?.  ??5?   "   ?? 5?   &   " ??66   .R?5?   *   ?  5?   .   ?? 5?   2   $
??Auto ?6C   ?? 5?   2   $??* ?6C   ?? 5?   2   $
??Auto ?6C    5?   .   ?? 5?   2   $
??Auto ?6@   ?? 5?   2   $??* ?6@   ?? 5?   2   $
??Auto ?6@   .+?5?   .   ?? #??Z 65   |?.  ??6v   C? *?? $" DataGridSelectAllButtonStyle??"  +y?6?   ?? *HeadersVisibility+#  Z #" Z! # ?? "$  ??6?  ?? *CellsPanelHorizontalOffset+# ?? "$    5?   .   $!% PART_ColumnHeadersPresenter??6M   $??1??6r   y?6?   ?? *HeadersVisibility+#  Z& #" Z! # ?? "$  ?? 5?   .   $!' PART_ScrollContentPresenter??6E   #( z??6j   $??2??6?   $??1??6?   ?? 5?   .   $) PART_VerticalScrollBar??68   $??2??6X   #+ z* 6h   $, Vertical=?6?   $??1??6?   #. z- 6  #y?z/ 6H  0 6?   ?? *VerticalOffset+$1 OneWay=?# ?? *TemplatedParent+6H  ? 5?   .   $??1??63   $??2??6C    5?   2   ?? 5?   6   ??6G   ?? **(NonFrozenColumnsViewportHorizontalOffset+# ?? "$  ?? 5?   6   $??* ?6G   .+?5?   2   ?? $) PART_HorizontalScrollBar??6<   $??1??6^   #+ z2 6n   $, 
Horizontal=?6?   #. z3 6  #y?z4 6C  0 6?   ?? *HorizontalOffset+$1 OneWay=?# ?? *TemplatedParent+6C  5?   /   5?   +   5?   '   .??5?   "   ?? # z 61   5?      5?      5?      5?       5?      ]? 5?       5?      ?? 5?       ?@??
IsGrouping . 6:   ?? 5?      " ?@%?IsVirtualizingWhenGrouping .  6\   ./?5?      ??  ? ?? .  6F   5?      5?      ?? 5?   
   "  6   .?5?      ??  ? ??
 ?  ??6+   ?? 5?       ? ??$ SemiBold"?6+   ?? 5?       ? ??
 ?????6+   ?? 5?       ? ??$ 20??6'   ?? 5?       ? ??$ Center=?6;   5?      ?? 5?   
   "  6    5?      P? 5?       ?@ 
IsSelected . . ?5?      ??  ? ??
 ?   ?63   ?? 5?       ? ??
 ?   ?64   5?      P? 5?       ?@J?IsMouseOver . . ?5?      ??  ? ??
 ?   ?63   ?? 5?       ? ??
 ?   ?64   ?? 5?       ? ??
 ?????63   5?      5?      5?      .??5?      ?? $ 5??6   $	??0.4q?5?      $ 1Q?5?      ??5?   
   ?? 5?      5 ?? EndPoint$	5 1,0&?6"   6 ?? 
StartPoint$	6 0,1&?61   .??5?      ? 7 ? Color$7 	#FF2B1A16??6   8 ? Offset$8 0Q?61   ? 5?      $7 DimGray??6   $8 1Q?6/   5?      ??5?   
   ?? 5?      $6 0,1.5&?6"   $	5 1,1&?65   .??5?      ? $	7 Red??6   $8 0Q?6+   ? 5?      $	7 Red??6   $8 0.498Q?6+   5?      ._?5?   
   ?  5?      ?? 5?      ?? 5?      ?? 5?      ?? 5?      ?? 5?      ?? 5?      ?? 5?      ?? 5?       5?      ?? 5?      ?? 5?      $??30 ?6    ?? 5?      $??40 ?6    ?? 5?      ?? 5?      ?? 5      ?? 5     ?? 5     ?? 5     ?? 5     .+?5	     ?? $??0??6   $??Cargo??5
     
???????$
??Bold"?5     $??40(?5     $??
Montserrat)?5     $??2??5     $??Center=?5     $??Center=?5     $??0,0,0,0q?5     $??3??5     ?? 5     -   5        9 ??Name$9 BtnRegresar??5     #???  5     $??0??5     $??0??5     $??4??5     
???  ??
???  ??$??Regresar??5     
???????: ? Cursor$
: Hand??5      $	??100??5!     $??40,0,0,0q?5"     $
??Left=?5#     $??30??5$     ; J? RenderTransformOrigin$; 
0.82,0.367&?5%     5&     ?? 5,     $??2??6   $+??%Realizar Modificaciones a los Cargos ??5-     
???????$??15(?5/     $??
Montserrat)?50     $??0??51     $??1??52     $??4??53     $??Center=?54     $
??Left=?55     $??40,0,0,0q?56     ?? 5:     -   5        $9 
CrearCargo??5:  <   #???  6   
??? ? ?
??? ? ?$??0??5=     $??3??5>     $??3??5?     $??40,0,0,0q?5@     $
: Hand??5A     $	??180??5B     $??30??5C     $
??Left=?5D     .??5G     ?? $??Crear Cargo??6   
???????$??15(?5I     $??Center=?5J     $??Center=?5K     5L     ?? 5P     $??4??6   $??Tabla de Cargos??5Q     
???????$??25(?5S     $??
Montserrat)?5T     $??8??5U     $??Center=?5V     $??center=?5W     $??0,0,0,0q?5X       5Z     -   5        <  Name$< 	GridDatos??5^     #???  5Z     $??5??6?   $??0??5[     $??4??5\     $??8??5]     =   AutoGenerateColumns= .  
???????
???   ?$??15(?5b     >   CanUserAddRows> .  ?   CanUserResizeColumns? . @   CanUserResizeRows@ .  A   CanUserSortColumnsA .  B   RowBackground
B ???? C   HeadersVisibility$C Column=?5h     D   GridLinesVisibility$D 
Horizontal=?5i     E   HorizontalGridLinesBrush
E ?  ??F   ColumnsF 5l     4  .System.Windows.Controls.DataGridTemplateColumn  5m     ,  &System.Windows.Controls.DataGridColumnG   Header$G Administrador??6-   H   Width5	  /System.Windows.Controls.DataGridLengthConverter$	H 250	 5n  1   I   CellTemplateI 5o     ?? 5p     .R?5q  "   ]? .+?5r  &   ?? $9 BtnConsultar??5s  -   -   5        $??	Consultar??5r  -   
??? ? ?$??80??5u  -   
?????? 
???????#???  5x  -   ??5z  -   ?? *id+?? 5{  &   $9 BtnModificar??5|  -   -   5        $??
Modificar ??5{  -   
????  ?
???????$??80??5  -   
?????? #???  5?  -   ??5?  -   ?? *id+?? 5?  &   $9 BtnEliminar??5?  -   -   5        $??Eliminar??5?  -   
???  ??
???????$??80??5?  -   
?????? #???  5?  -   ??5?  -   ?? *id+5?  #   5?     5?     0
  *System.Windows.Controls.DataGridTextColumn
  5?     $G Nombre Cargo??6)   $H *	 5?  )   1  +System.Windows.Controls.DataGridBoundColumnJ   BindingJ 5?  )   ?? *nombrecargo+
  5?     $G Descripcion Cargo??6)   $H *	 5?  )   J 5?  )   ?? *descripcion+
  5?     $G Codigo Cargo ??6)   $H *	 5?  )   J 5?  )   ?? *codigo+5?      ? 5?     -   5        K  ?Name$K 
FrameCargo??5?     $??0??5?     $??0??5?     $??10??5?     $??8??5?     5?     5?     5?     