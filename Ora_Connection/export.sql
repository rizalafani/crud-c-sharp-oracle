--------------------------------------------------------
--  File created - Jumat-Agustus-02-2013   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table MAHASISWA
--------------------------------------------------------

  CREATE TABLE "RIZAL"."MAHASISWA" 
   (	"NIM" NUMBER, 
	"NAMA" VARCHAR2(100 BYTE), 
	"ALAMAT" VARCHAR2(100 BYTE)
   ) PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "USERS" ;
REM INSERTING into RIZAL.MAHASISWA
SET DEFINE OFF;
Insert into RIZAL.MAHASISWA (NIM,NAMA,ALAMAT) values ('123','Asharul Fahrizi','Songgon, Banyuwangi');
Insert into RIZAL.MAHASISWA (NIM,NAMA,ALAMAT) values ('101','Ahmad Rizal Afani','Kertosari, Banyuwangi');
Insert into RIZAL.MAHASISWA (NIM,NAMA,ALAMAT) values ('107','Mokammad Romli','Wongsorejo');
--------------------------------------------------------
--  DDL for Index MAHASISWA_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "RIZAL"."MAHASISWA_PK" ON "RIZAL"."MAHASISWA" ("NIM") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  Constraints for Table MAHASISWA
--------------------------------------------------------

  ALTER TABLE "RIZAL"."MAHASISWA" ADD CONSTRAINT "MAHASISWA_PK" PRIMARY KEY ("NIM")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "USERS"  ENABLE;
 
  ALTER TABLE "RIZAL"."MAHASISWA" MODIFY ("NIM" NOT NULL ENABLE);
