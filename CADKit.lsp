(vl-load-com)
(cond
	((= (getvar "PRODUCT") "ZWCAD") (vl-cmdf "netload" "CADKitZwCAD.dll"))
	((= (getvar "PRODUCT") "AutoCAD") (vl-cmdf "netload" "CADKitAutoCAD.dll"))
	(T (progn
			(princ "\nNieznana platforma CAD. CaDKit nie moze by� wczytany.")
		)
	)
)
(command "CK_AAA")
(princ)
