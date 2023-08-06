#line 1 "E:/Document/Giao tiep DKTBNV/19486901_TranBaTy_GTTBNV_DHDTMT15B/Baitap USB/USB_NangCao_/MiKroC/USB_NangCao.c"




bit oldstate;
unsigned char readbuff[ 64 ] absolute 0x500;
unsigned char writebuff[ 64 ] absolute 0x540;

void interrupt()
{
 if(PIR2.USBIF == 1)
 {
 PIR2.USBIF = 0;
 USB_Interrupt_Proc();
 }
 else if(INTCON.INT0IF == 1)
 {
 INTCON.INT0IF = 0;
 writebuff[0] = 'S';
 oldstate = 1;
 }
 else if (INTCON3.INT1F == 1)
 {
 INTCON3.INT1IF = 0;
 oldstate = 1;
 RE0_bit = !RE0_bit;
 if (RD0_bit == 0)
 {
 writebuff[0] = 'W';
 }
 else
 {
 writebuff[0] = 'Q';
 }
 }
}
void main(void)
{
 ADCON1 |= 0x0F;
 CMCON |= 0x07;

 PORTB = 0x00; LATB = 0x00;
 TRISB.TRISB0 = 1;
 INTCON2.RBPU = 0;

 PORTE = 0x00; LATE = 0x00;
 TRISE.TRISE1 = 0;
 TRISE.TRISE0 = 0;

 PORTD = 0x00; LATD = 0x00;
 TRISD.TRISD0 = 1;

 HID_Enable(&readbuff,&writebuff);

 INTCON.INT0IF = 0;
 INTCON.INT0IE = 1;
 INTCON2.INTEDG0 = 1;

 INTCON3.INT1IF = 0;
 INTCON3.INT1IE = 1;
 INTCON3.INTEDG1 = 1;

 PIR2.USBIF = 0;
 PIE2.USBIE = 1;
 INTCON.GIE = 1;
 INTCON.PEIE = 1;
 while(1)
 {

 if(HID_Read() != 0)
 {
 if(readbuff[0] == 1)
 {
 RE1_bit =  1 ;
 writebuff[0] = 'O';
 HID_Write(&writebuff, 64 );
 }
 else if(readbuff[0] == 0)
 {
 RE1_bit =  0 ;
 writebuff[0] = 'F';
 HID_Write(&writebuff, 64 );
 }

 else if(readbuff[0] == 2)
 {
 RE0_bit =  1 ;
 writebuff[0] = 'B';
 HID_Write(&writebuff, 64 );
 }
 else if(readbuff[0] == 3)
 {
 RE0_bit =  0 ;
 writebuff[0] = 'T';
 HID_Write(&writebuff, 64 );
 }
 }

 if (oldstate == 1)
 {
 oldstate = 0;
 HID_Write(&writebuff, 64 );
 }
 }
}
