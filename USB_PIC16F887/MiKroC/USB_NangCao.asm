
_interrupt:

;USB_NangCao.c,9 :: 		void interrupt()
;USB_NangCao.c,11 :: 		if(PIR2.USBIF == 1)
	BTFSS       PIR2+0, 5 
	GOTO        L_interrupt0
;USB_NangCao.c,13 :: 		PIR2.USBIF = 0;
	BCF         PIR2+0, 5 
;USB_NangCao.c,14 :: 		USB_Interrupt_Proc();
	CALL        _USB_Interrupt_Proc+0, 0
;USB_NangCao.c,15 :: 		}
	GOTO        L_interrupt1
L_interrupt0:
;USB_NangCao.c,16 :: 		else if(INTCON.INT0IF == 1)
	BTFSS       INTCON+0, 1 
	GOTO        L_interrupt2
;USB_NangCao.c,18 :: 		INTCON.INT0IF = 0;
	BCF         INTCON+0, 1 
;USB_NangCao.c,19 :: 		writebuff[0] = 'S';
	MOVLW       83
	MOVWF       1344 
;USB_NangCao.c,20 :: 		oldstate = 1;
	BSF         _oldstate+0, BitPos(_oldstate+0) 
;USB_NangCao.c,21 :: 		}
	GOTO        L_interrupt3
L_interrupt2:
;USB_NangCao.c,22 :: 		else if (INTCON3.INT1F == 1)
	BTFSS       INTCON3+0, 0 
	GOTO        L_interrupt4
;USB_NangCao.c,24 :: 		INTCON3.INT1IF = 0;
	BCF         INTCON3+0, 0 
;USB_NangCao.c,25 :: 		oldstate = 1;
	BSF         _oldstate+0, BitPos(_oldstate+0) 
;USB_NangCao.c,26 :: 		RE0_bit = !RE0_bit;
	BTG         RE0_bit+0, BitPos(RE0_bit+0) 
;USB_NangCao.c,27 :: 		if (RD0_bit == 0)
	BTFSC       RD0_bit+0, BitPos(RD0_bit+0) 
	GOTO        L_interrupt5
;USB_NangCao.c,29 :: 		writebuff[0] = 'W';
	MOVLW       87
	MOVWF       1344 
;USB_NangCao.c,30 :: 		}
	GOTO        L_interrupt6
L_interrupt5:
;USB_NangCao.c,33 :: 		writebuff[0] = 'Q';
	MOVLW       81
	MOVWF       1344 
;USB_NangCao.c,34 :: 		}
L_interrupt6:
;USB_NangCao.c,35 :: 		}
L_interrupt4:
L_interrupt3:
L_interrupt1:
;USB_NangCao.c,36 :: 		}
L_end_interrupt:
L__interrupt19:
	RETFIE      1
; end of _interrupt

_main:

;USB_NangCao.c,37 :: 		void main(void)
;USB_NangCao.c,39 :: 		ADCON1 |= 0x0F;
	MOVLW       15
	IORWF       ADCON1+0, 1 
;USB_NangCao.c,40 :: 		CMCON |= 0x07;
	MOVLW       7
	IORWF       CMCON+0, 1 
;USB_NangCao.c,42 :: 		PORTB = 0x00; LATB = 0x00;
	CLRF        PORTB+0 
	CLRF        LATB+0 
;USB_NangCao.c,43 :: 		TRISB.TRISB0 = 1;
	BSF         TRISB+0, 0 
;USB_NangCao.c,44 :: 		INTCON2.RBPU = 0;
	BCF         INTCON2+0, 7 
;USB_NangCao.c,46 :: 		PORTE = 0x00; LATE = 0x00;
	CLRF        PORTE+0 
	CLRF        LATE+0 
;USB_NangCao.c,47 :: 		TRISE.TRISE1 = 0;
	BCF         TRISE+0, 1 
;USB_NangCao.c,48 :: 		TRISE.TRISE0 = 0;
	BCF         TRISE+0, 0 
;USB_NangCao.c,50 :: 		PORTD = 0x00; LATD = 0x00;
	CLRF        PORTD+0 
	CLRF        LATD+0 
;USB_NangCao.c,51 :: 		TRISD.TRISD0 = 1;
	BSF         TRISD+0, 0 
;USB_NangCao.c,53 :: 		HID_Enable(&readbuff,&writebuff);
	MOVLW       _readbuff+0
	MOVWF       FARG_HID_Enable_readbuff+0 
	MOVLW       hi_addr(_readbuff+0)
	MOVWF       FARG_HID_Enable_readbuff+1 
	MOVLW       _writebuff+0
	MOVWF       FARG_HID_Enable_writebuff+0 
	MOVLW       hi_addr(_writebuff+0)
	MOVWF       FARG_HID_Enable_writebuff+1 
	CALL        _HID_Enable+0, 0
;USB_NangCao.c,55 :: 		INTCON.INT0IF = 0;
	BCF         INTCON+0, 1 
;USB_NangCao.c,56 :: 		INTCON.INT0IE = 1;
	BSF         INTCON+0, 4 
;USB_NangCao.c,57 :: 		INTCON2.INTEDG0 = 1;
	BSF         INTCON2+0, 6 
;USB_NangCao.c,59 :: 		INTCON3.INT1IF = 0;
	BCF         INTCON3+0, 0 
;USB_NangCao.c,60 :: 		INTCON3.INT1IE = 1;
	BSF         INTCON3+0, 3 
;USB_NangCao.c,61 :: 		INTCON3.INTEDG1 = 1;
	BSF         INTCON3+0, 5 
;USB_NangCao.c,63 :: 		PIR2.USBIF = 0;
	BCF         PIR2+0, 5 
;USB_NangCao.c,64 :: 		PIE2.USBIE = 1;
	BSF         PIE2+0, 5 
;USB_NangCao.c,65 :: 		INTCON.GIE = 1;
	BSF         INTCON+0, 7 
;USB_NangCao.c,66 :: 		INTCON.PEIE = 1;
	BSF         INTCON+0, 6 
;USB_NangCao.c,67 :: 		while(1)
L_main7:
;USB_NangCao.c,70 :: 		if(HID_Read() != 0)
	CALL        _HID_Read+0, 0
	MOVF        R0, 0 
	XORLW       0
	BTFSC       STATUS+0, 2 
	GOTO        L_main9
;USB_NangCao.c,72 :: 		if(readbuff[0] == 1)
	MOVF        1280, 0 
	XORLW       1
	BTFSS       STATUS+0, 2 
	GOTO        L_main10
;USB_NangCao.c,74 :: 		RE1_bit = led_on;
	BSF         RE1_bit+0, BitPos(RE1_bit+0) 
;USB_NangCao.c,75 :: 		writebuff[0] = 'O';
	MOVLW       79
	MOVWF       1344 
;USB_NangCao.c,76 :: 		HID_Write(&writebuff,out_size);
	MOVLW       _writebuff+0
	MOVWF       FARG_HID_Write_writebuff+0 
	MOVLW       hi_addr(_writebuff+0)
	MOVWF       FARG_HID_Write_writebuff+1 
	MOVLW       64
	MOVWF       FARG_HID_Write_len+0 
	CALL        _HID_Write+0, 0
;USB_NangCao.c,77 :: 		}
	GOTO        L_main11
L_main10:
;USB_NangCao.c,78 :: 		else if(readbuff[0] == 0)
	MOVF        1280, 0 
	XORLW       0
	BTFSS       STATUS+0, 2 
	GOTO        L_main12
;USB_NangCao.c,80 :: 		RE1_bit = led_off;
	BCF         RE1_bit+0, BitPos(RE1_bit+0) 
;USB_NangCao.c,81 :: 		writebuff[0] = 'F';
	MOVLW       70
	MOVWF       1344 
;USB_NangCao.c,82 :: 		HID_Write(&writebuff,out_size);
	MOVLW       _writebuff+0
	MOVWF       FARG_HID_Write_writebuff+0 
	MOVLW       hi_addr(_writebuff+0)
	MOVWF       FARG_HID_Write_writebuff+1 
	MOVLW       64
	MOVWF       FARG_HID_Write_len+0 
	CALL        _HID_Write+0, 0
;USB_NangCao.c,83 :: 		}
	GOTO        L_main13
L_main12:
;USB_NangCao.c,85 :: 		else if(readbuff[0] == 2)
	MOVF        1280, 0 
	XORLW       2
	BTFSS       STATUS+0, 2 
	GOTO        L_main14
;USB_NangCao.c,87 :: 		RE0_bit = led_on;
	BSF         RE0_bit+0, BitPos(RE0_bit+0) 
;USB_NangCao.c,88 :: 		writebuff[0] = 'B';
	MOVLW       66
	MOVWF       1344 
;USB_NangCao.c,89 :: 		HID_Write(&writebuff,out_size);
	MOVLW       _writebuff+0
	MOVWF       FARG_HID_Write_writebuff+0 
	MOVLW       hi_addr(_writebuff+0)
	MOVWF       FARG_HID_Write_writebuff+1 
	MOVLW       64
	MOVWF       FARG_HID_Write_len+0 
	CALL        _HID_Write+0, 0
;USB_NangCao.c,90 :: 		}
	GOTO        L_main15
L_main14:
;USB_NangCao.c,91 :: 		else if(readbuff[0] == 3)
	MOVF        1280, 0 
	XORLW       3
	BTFSS       STATUS+0, 2 
	GOTO        L_main16
;USB_NangCao.c,93 :: 		RE0_bit = led_off;
	BCF         RE0_bit+0, BitPos(RE0_bit+0) 
;USB_NangCao.c,94 :: 		writebuff[0] = 'T';
	MOVLW       84
	MOVWF       1344 
;USB_NangCao.c,95 :: 		HID_Write(&writebuff,out_size);
	MOVLW       _writebuff+0
	MOVWF       FARG_HID_Write_writebuff+0 
	MOVLW       hi_addr(_writebuff+0)
	MOVWF       FARG_HID_Write_writebuff+1 
	MOVLW       64
	MOVWF       FARG_HID_Write_len+0 
	CALL        _HID_Write+0, 0
;USB_NangCao.c,96 :: 		}
L_main16:
L_main15:
L_main13:
L_main11:
;USB_NangCao.c,97 :: 		}
L_main9:
;USB_NangCao.c,99 :: 		if (oldstate == 1)
	BTFSS       _oldstate+0, BitPos(_oldstate+0) 
	GOTO        L_main17
;USB_NangCao.c,101 :: 		oldstate = 0;
	BCF         _oldstate+0, BitPos(_oldstate+0) 
;USB_NangCao.c,102 :: 		HID_Write(&writebuff,out_size);
	MOVLW       _writebuff+0
	MOVWF       FARG_HID_Write_writebuff+0 
	MOVLW       hi_addr(_writebuff+0)
	MOVWF       FARG_HID_Write_writebuff+1 
	MOVLW       64
	MOVWF       FARG_HID_Write_len+0 
	CALL        _HID_Write+0, 0
;USB_NangCao.c,103 :: 		}
L_main17:
;USB_NangCao.c,104 :: 		}
	GOTO        L_main7
;USB_NangCao.c,105 :: 		}
L_end_main:
	GOTO        $+0
; end of _main
