(vl-load-com)
(cond
	((= (getvar "PRODUCT") "ZWCAD") (vl-cmdf "netload" "CADKitZwCAD.dll"))
	((= (getvar "PRODUCT") "AutoCAD") (vl-cmdf "netload" "CADKitAutoCAD.dll"))
	(T (progn
			(princ "\nNieznana platforma CAD. CADKit nie mo�e by� wczytany.")
		)
	)
)
(vl-cmdf "netload" "CADKitXData.dll")
(command "CK_XDAPPLIST")
(princ)
