.code
	MyProc1 proc
		xor RSI,RSI
		mov	EBX, DWORD PTR [RCX+40]
		SHR	EBX,2
		add	RCX,44

hoop:
		movsx	EAX,WORD PTR [RCX+RSI*4]
		movsx	EDX,WORD PTR [RCX+RSI*4+2]
		add	EAX,EDX
		SAR EAX,1
		mov	WORD PTR [RCX+RSI*2], AX
		INC	RSI
		DEC	EBX
		JNE	hoop

		sub	RCX,44
		mov	EBX, DWORD PTR [RCX+40]
		SHR	EBX,1
		mov	DWORD PTR [RCX+40],EBX
		mov	WORD PTR [RCX+22],1
		shr	WORD PTR [RCX+32],1
		shr	DWORD PTR [RCX+28],1
		mov EAX, EBX
		add	EAX,40
		ret
	MyProc1 endp
end