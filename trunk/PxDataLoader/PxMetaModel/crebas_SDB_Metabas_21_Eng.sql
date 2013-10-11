/*==============================================================*/
/* Database:       SDB_Metabase_Eng, version 2.1                */
/* DBMS name:      Microsoft SQL Server 2000                    */
/* Created on:     2006-06-28 14:38:48                          */
/* Created by:     Anneli Eriksson                              */
/* Run:            2006-06-28, completed without errors         */
/*==============================================================*/


/*==============================================================*/
/* Table: ColumnCode                                            */
/*==============================================================*/
create table dbo.ColumnCode (
   MetaTable            varchar(30)          not null,
   ColumnName           varchar(30)          not null,
   Code                 varchar(10)          not null,
   PresText             varchar(80)          not null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint ColumnCode_pk primary key clustered (MetaTable, ColumnName, Code)
)
go


/*==============================================================*/
/* Table: ColumnCode_Eng                                        */
/*==============================================================*/
create table dbo.ColumnCode_Eng (
   MetaTable            varchar(30)          not null,
   ColumnName           varchar(30)          not null,
   Code                 varchar(10)          not null,
   CodeEng              varchar(10)          not null,
   PresText             varchar(80)          not null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint ColumnCode_Eng_pk primary key clustered (MetaTable, ColumnName, Code)
)
go


/*==============================================================*/
/* Table: Contents                                              */
/*==============================================================*/
create table dbo.Contents (
   MainTable            varchar(20)          not null,
   Contents             varchar(20)          not null,
   PresText             varchar(250)         not null,
   PresTextS            varchar(80)          null,
   PresCode             varchar(8)           not null,
   Copyright            char(1)              not null,
   StatAuthority        varchar(20)          not null,
   Producer             varchar(20)          not null,
   LastUpdated          smalldatetime        null,
   Published            smalldatetime        null,
   Unit                 varchar(60)          not null,
   PresDecimals         smallint             not null,
   PresCellsZero        char(1)              not null,
   PresMissingLine      varchar(2)           null,
   AggregPossible       char(1)              not null,
   RefPeriod            varchar(80)          null,
   StockFA              char(1)              not null,
   BasePeriod           varchar(20)          null,
   CFPrices             char(1)              null,
   DayAdj               char(1)              not null,
   SeasAdj              char(1)              not null,
   FootnoteContents     char(1)              not null,
   FootnoteVariable     char(1)              not null,
   FootnoteValue        char(1)              not null,
   FootnoteTime         char(1)              not null,
   StoreColumnNo        smallint             not null,
   StoreFormat          char(1)              not null,
   StoreNoChar          smallint             not null,
   StoreDecimals        smallint             not null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint Contents_pk primary key clustered (MainTable, Contents),
   constraint Contents_PresDecimals check (PresDecimals between 0 and 6)
)
go


/*==============================================================*/
/* Table: ContentsTime                                          */
/*==============================================================*/
create table dbo.ContentsTime (
   MainTable            varchar(20)          not null,
   Contents             varchar(20)          not null,
   TimePeriod           varchar(20)          not null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint ContentsTime_pk primary key clustered (MainTable, Contents, TimePeriod)
)
go


/*==============================================================*/
/* Table: Contents_Eng                                          */
/*==============================================================*/
create table dbo.Contents_Eng (
   MainTable            varchar(20)          not null,
   Contents             varchar(20)          not null,
   PresText             varchar(250)         not null,
   PresTextS            varchar(80)          null,
   Unit                 varchar(60)          null,
   RefPeriod            varchar(80)          null,
   BasePeriod           varchar(20)          null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint Contents_Eng_pk primary key clustered (MainTable, Contents)
)
go


/*==============================================================*/
/* Table: DataStorage                                           */
/*==============================================================*/
create table DataStorage (
   ProductId            varchar(20)          not null,
   ServerName           varchar(8)           not null,
   DatabaseName         varchar(30)          not null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint DataStorage_pk primary key  (ProductId)
)
go


/*==============================================================*/
/* Table: Footnote                                              */
/*==============================================================*/
create table dbo.Footnote (
   FootnoteNo           numeric(6,0)         not null,
   FootnoteType         char(1)              not null,
   ShowFootnote         char(1)              not null,
   MandOpt              char(1)              not null,
   FootnoteText         text                 not null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint Footnote_pk primary key clustered (FootnoteNo)
)
go


/*==============================================================*/
/* Table: FootnoteContTime                                      */
/*==============================================================*/
create table dbo.FootnoteContTime (
   MainTable            varchar(20)          not null,
   Contents             varchar(20)          not null,
   TimePeriod           varchar(20)          not null,
   FootnoteNo           numeric(6,0)         not null,
   Cellnote             char(1)              not null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint FootnoteContTime_pk primary key clustered (MainTable, Contents, TimePeriod, FootnoteNo)
)
go


/*==============================================================*/
/* Table: FootnoteContValue                                     */
/*==============================================================*/
create table dbo.FootnoteContValue (
   MainTable            varchar(20)          not null,
   Contents             varchar(20)          not null,
   Variable             varchar(20)          not null,
   ValuePool            varchar(20)          not null,
   ValueCode            varchar(20)          not null,
   FootnoteNo           numeric(6,0)         not null,
   Cellnote             char(1)              not null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint FootnoteContValue_pk primary key clustered (MainTable, Contents, Variable, ValuePool, ValueCode, FootnoteNo)
)
go


/*==============================================================*/
/* Table: FootnoteContVbl                                       */
/*==============================================================*/
create table dbo.FootnoteContVbl (
   MainTable            varchar(20)          not null,
   Contents             varchar(20)          not null,
   Variable             varchar(20)          not null,
   FootnoteNo           numeric(6,0)         not null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint FootnoteContVbl_pk primary key clustered (MainTable, Contents, Variable, FootnoteNo)
)
go


/*==============================================================*/
/* Table: FootnoteContents                                      */
/*==============================================================*/
create table dbo.FootnoteContents (
   MainTable            varchar(20)          not null,
   Contents             varchar(20)          not null,
   FootnoteNo           numeric(6,0)         not null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint FootnoteContents_pk primary key clustered (MainTable, Contents, FootnoteNo)
)
go


/*==============================================================*/
/* Table: FootnoteMainTable                                     */
/*==============================================================*/
create table FootnoteMainTable (
   MainTable            varchar(20)          not null,
   FootnoteNo           numeric(6,0)         not null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint FootnoteMainTable_pk primary key  (MainTable, FootnoteNo)
)
go


/*==============================================================*/
/* Table: FootnoteMaintValue                                    */
/*==============================================================*/
create table dbo.FootnoteMaintValue (
   MainTable            varchar(20)          not null,
   Variable             varchar(20)          not null,
   ValuePool            varchar(20)          not null,
   ValueCode            varchar(20)          not null,
   FootnoteNo           numeric(6,0)         not null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint FootnoteMaintValue_pk primary key clustered (MainTable, Variable, ValuePool, ValueCode, FootnoteNo)
)
go


/*==============================================================*/
/* Table: FootnoteMenuSel                                       */
/*==============================================================*/
create table dbo.FootnoteMenuSel (
   Menu                 varchar(20)          not null,
   Selection            varchar(20)          not null,
   FootnoteNo           numeric(6,0)         not null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint FootnoteMenuSel_pk primary key clustered (Menu, Selection, FootnoteNo)
)
go


/*==============================================================*/
/* Table: FootnoteSubTable                                      */
/*==============================================================*/
create table FootnoteSubTable (
   MainTable            varchar(20)          not null,
   SubTable             varchar(20)          not null,
   FootnoteNo           numeric(6,0)         not null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint FootnoteSubTable_pk primary key  (MainTable, SubTable, FootnoteNo)
)
go


/*==============================================================*/
/* Table: FootnoteValue                                         */
/*==============================================================*/
create table dbo.FootnoteValue (
   ValuePool            varchar(20)          not null,
   ValueCode            varchar(20)          not null,
   FootnoteNo           numeric(6,0)         not null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint FootnoteValue_pk primary key clustered (ValuePool, ValueCode, FootnoteNo)
)
go


/*==============================================================*/
/* Table: FootnoteVariable                                      */
/*==============================================================*/
create table dbo.FootnoteVariable (
   Variable             varchar(20)          not null,
   FootnoteNo           numeric(6,0)         not null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint FootnoteVariable_pk primary key clustered (Variable, FootnoteNo)
)
go


/*==============================================================*/
/* Table: Footnote_Eng                                          */
/*==============================================================*/
create table dbo.Footnote_Eng (
   FootnoteNo           numeric(6,0)         not null,
   FootnoteText         text                 not null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint Footnote_Eng_pk primary key clustered (FootnoteNo)
)
go


/*==============================================================*/
/* Table: Grouping                                              */
/*==============================================================*/
create table dbo.Grouping (
   ValuePool            varchar(20)          not null,
   Grouping             varchar(30)          not null,
   Prestext             varchar(80)          not null,
   Description          varchar(200)         null,
   GroupPres            char(1)              null,
   GeoAreaNo            smallint             null,
   KDBid                varchar(20)          null,
   SortCode             varchar(20)          null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint Grouping_pk primary key clustered (ValuePool, Grouping)
)
go


/*==============================================================*/
/* Table: Grouping_Eng                                          */
/*==============================================================*/
create table dbo.Grouping_Eng (
   ValuePool            varchar(20)          not null,
   Grouping             varchar(30)          not null,
   PresText             varchar(80)          not null,
   SortCode             varchar(20)          null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint Grouping_Eng_pk primary key clustered (ValuePool, Grouping)
)
go


/*==============================================================*/
/* Table: Link                                                  */
/*==============================================================*/
create table Link (
   LinkId               int                  not null,
   Link                 varchar(250)         not null,
   LinkText             varchar(250)         not null,
   PresCategory         char(1)              not null,
   LinkPres             char(1)              null,
   SortCode             varchar(20)          null,
   Description          varchar(200)         null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint Link_pk primary key  (LinkId)
)
go


/*==============================================================*/
/* Table: LinkMenuSelection                                     */
/*==============================================================*/
create table LinkMenuSelection (
   Menu                 varchar(20)          not null,
   Selection            varchar(20)          not null,
   LinkId               int                  not null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint LinkMenuSelection_pk primary key  (Menu, Selection, LinkId)
)
go


/*==============================================================*/
/* Table: Link_Eng                                              */
/*==============================================================*/
create table Link_Eng (
   LinkId               int                  not null,
   Link                 varchar(250)         not null,
   LinkText             varchar(250)         not null,
   SortCode             varchar(20)          null,
   Description          varchar(200)         null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint Link_Eng_pk primary key  (LinkId)
)
go


/*==============================================================*/
/* Table: MainTable                                             */
/*==============================================================*/
create table dbo.MainTable (
   MainTable            varchar(20)          not null,
   TableStatus          char(1)              not null,
   PresText             varchar(250)         not null,
   PresTextS            varchar(150)         null,
   ContentsVariable     varchar(80)          null,
   TableId              varchar(20)          not null,
   PresCategory         char(1)              not null,
   SpecCharExists       char(1)              not null,
   SubjectCode          varchar(20)          not null,
   ProductId            varchar(20)          null,
   TimeScale            varchar(20)          not null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint MainTable_pk primary key clustered (MainTable),
   constraint MainTable_uk1 unique nonclustered (PresText)
)
go


/*==============================================================*/
/* Table: MainTablePerson                                       */
/*==============================================================*/
create table MainTablePerson (
   MainTable            varchar(20)          not null,
   PersonCode           varchar(20)          not null,
   RolePerson           char(1)              not null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint MainTablePerson_pk primary key  (PersonCode, MainTable, RolePerson)
)
go


/*==============================================================*/
/* Table: MainTable_Eng                                         */
/*==============================================================*/
create table dbo.MainTable_Eng (
   MainTable            varchar(20)          not null,
   Status               char(1)              not null,
   Published            char(1)              not null,
   PresText             varchar(250)         null,
   PresTextS            varchar(150)         null,
   ContentsVariable     varchar(80)          null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint MainTable_Eng_pk primary key clustered (MainTable),
   constraint MainTable_Eng_uk1 unique nonclustered (PresText)
)
go


/*==============================================================*/
/* Table: MenuSelection                                         */
/*==============================================================*/
create table dbo.MenuSelection (
   Menu                 varchar(20)          not null,
   Selection            varchar(20)          not null,
   PresText             varchar(100)         null,
   PresTextS            varchar(20)          null,
   Description          varchar(200)         null,
   LevelNo              char(1)              not null,
   SortCode             varchar(20)          null,
   Presentation         char(1)              not null,
   InternalId           varchar(20)          null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint MenuSelection_pk primary key clustered (Menu, Selection)
)
go


/*==============================================================*/
/* Table: MenuSelection_Eng                                     */
/*==============================================================*/
create table dbo.MenuSelection_Eng (
   Menu                 varchar(20)          not null,
   Selection            varchar(20)          not null,
   PresText             varchar(100)         null,
   PresTextS            varchar(20)          null,
   Description          varchar(200)         null,
   SortCode             varchar(20)          null,
   Presentation         char(1)              not null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint MenuSelection_Eng_pk primary key clustered (Menu, Selection)
)
go


/*==============================================================*/
/* Table: MetaAdm                                               */
/*==============================================================*/
create table dbo.MetaAdm (
   Property             varchar(30)          not null,
   Value                varchar(20)          not null,
   Description          varchar(200)         null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint PK_MetaAdm primary key  (Property)
)
go


/*==============================================================*/
/* Table: MetabaseInfo                                          */
/*==============================================================*/
create table dbo.MetabaseInfo (
   Model                varchar(20)          not null,
   ModelVersion         varchar(10)          not null,
   DatabaseRole         varchar(20)          not null,
   constraint MetabaseInfo_pk primary key clustered (Model)
)
go


/*==============================================================*/
/* Table: Organization                                          */
/*==============================================================*/
create table dbo.Organization (
   OrganizationCode     varchar(20)          not null,
   OrganizationName     varchar(60)          not null,
   Department           varchar(60)          null,
   Unit                 varchar(60)          null,
   WebAddress           varchar(100)         null,
   InternalId           varchar(20)          null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint Organization_pk primary key clustered (OrganizationCode)
)
go


/*==============================================================*/
/* Table: Organization_Eng                                      */
/*==============================================================*/
create table dbo.Organization_Eng (
   OrganizationCode     varchar(20)          not null,
   OrganizationName     varchar(60)          not null,
   Department           varchar(60)          null,
   Unit                 varchar(60)          null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint Organization_Eng_pk primary key clustered (OrganizationCode)
)
go


/*==============================================================*/
/* Table: Person                                                */
/*==============================================================*/
create table dbo.Person (
   PersonCode           varchar(20)          not null,
   Forename             varchar(50)          not null,
   Surname              varchar(50)          null,
   OrganizationCode     varchar(20)          not null,
   PhonePrefix          varchar(4)           not null,
   PhoneNo              varchar(20)          not null,
   FaxNo                varchar(20)          null,
   Email                varchar(80)          null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint Person_pk primary key clustered (PersonCode)
)
go


/*==============================================================*/
/* Table: SpecialCharacter                                      */
/*==============================================================*/
create table SpecialCharacter (
   CharacterType        varchar(2)           not null,
   PresCharacter        varchar(20)          not null,
   AggregPossible       char(1)              not null,
   DataCellPres         char(1)              not null,
   DataCellFilled       char(1)              null,
   PresText             varchar(200)         null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint SpecialCharacter_pk primary key  (CharacterType)
)
go


/*==============================================================*/
/* Table: SpecialCharacter_Eng                                  */
/*==============================================================*/
create table SpecialCharacter_Eng (
   CharacterType        varchar(2)           not null,
   PresCharacter        varchar(20)          not null,
   PresText             varchar(200)         null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint SpecialCharacter_Eng_pk primary key  (CharacterType)
)
go


/*==============================================================*/
/* Table: SubTable                                              */
/*==============================================================*/
create table dbo.SubTable (
   MainTable            varchar(20)          not null,
   SubTable             varchar(20)          not null,
   PresText             varchar(250)         not null,
   CleanTable           char(1)              not null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint SubTable_pk primary key clustered (MainTable, SubTable),
   constraint SubTable_uk1 unique nonclustered (PresText)
)
go


/*==============================================================*/
/* Table: SubTableVariable                                      */
/*==============================================================*/
create table dbo.SubTableVariable (
   MainTable            varchar(20)          not null,
   SubTable             varchar(20)          not null,
   Variable             varchar(20)          not null,
   ValueSet             varchar(30)          null,
   VariableType         char(1)              not null,
   StoreColumnNo        smallint             not null,
   UserID               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint SubTableVariable_pk primary key clustered (MainTable, SubTable, Variable)
)
go


/*==============================================================*/
/* Table: SubTable_Eng                                          */
/*==============================================================*/
create table dbo.SubTable_Eng (
   MainTable            varchar(20)          not null,
   SubTable             varchar(20)          not null,
   PresText             varchar(250)         null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint SubTable_Eng_pk primary key clustered (MainTable, SubTable),
   constraint SubTable_Eng_uk1 unique nonclustered (PresText)
)
go


/*==============================================================*/
/* Table: TextCatalog                                           */
/*==============================================================*/
create table TextCatalog (
   TextCatalogNo        int                  not null,
   TextType             varchar(30)          not null,
   PresText             varchar(100)         not null,
   Description          varchar(200)         null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint PK_TextCatalog primary key  (TextCatalogNo)
)
go


/*==============================================================*/
/* Table: TextCatalog_Eng                                       */
/*==============================================================*/
create table TextCatalog_Eng (
   TextCatalogNo        int                  not null,
   TextType             varchar(30)          not null,
   PresText             varchar(100)         not null,
   Description          varchar(200)         null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint PK_TextCatalog_Eng primary key  (TextCatalogNo)
)
go


/*==============================================================*/
/* Table: TimeScale                                             */
/*==============================================================*/
create table dbo.TimeScale (
   TimeScale            varchar(20)          not null,
   PresText             varchar(80)          not null,
   TimeScalePres        char(1)              null,
   Regular              char(1)              not null,
   TimeUnit             char(1)              not null,
   Frequency            smallint             null,
   StoreFormat          varchar(20)          not null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint TimeScale_pk primary key clustered (TimeScale)
)
go


/*==============================================================*/
/* Table: TimeScale_Eng                                         */
/*==============================================================*/
create table dbo.TimeScale_Eng (
   TimeScale            varchar(20)          not null,
   PresText             varchar(80)          not null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint TimeScale_Eng_pk primary key clustered (TimeScale)
)
go


/*==============================================================*/
/* Table: VSGroup                                               */
/*==============================================================*/
create table dbo.VSGroup (
   ValueSet             varchar(30)          not null,
   Grouping             varchar(30)          not null,
   GroupCode            varchar(20)          not null,
   ValueCode            varchar(20)          not null,
   ValuePool            varchar(20)          not null,
   SortCode             varchar(20)          null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint VSGroup_pk primary key clustered (ValueSet, Grouping, GroupCode, ValueCode, ValuePool)
)
go


/*==============================================================*/
/* Table: VSGroup_Eng                                           */
/*==============================================================*/
create table dbo.VSGroup_Eng (
   ValueSet             varchar(30)          not null,
   Grouping             varchar(30)          not null,
   GroupCode            varchar(20)          not null,
   ValueCode            varchar(20)          not null,
   ValuePool            varchar(20)          not null,
   SortCode             varchar(20)          null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint VSGroup_Eng_pk primary key clustered (ValueSet, Grouping, GroupCode, ValueCode, ValuePool)
)
go


/*==============================================================*/
/* Table: VSValue                                               */
/*==============================================================*/
create table dbo.VSValue (
   ValueSet             varchar(30)          not null,
   ValuePool            varchar(20)          not null,
   ValueCode            varchar(20)          not null,
   SortCode             varchar(20)          null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint VSValue_pk primary key clustered (ValueSet, ValuePool, ValueCode)
)
go


/*==============================================================*/
/* Table: VSValue_Eng                                           */
/*==============================================================*/
create table VSValue_Eng (
   ValueSet             varchar(30)          not null,
   ValuePool            varchar(20)          not null,
   ValueCode            varchar(20)          not null,
   SortCode             varchar(20)          null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint VSValue_Eng_pk primary key  (ValueSet, ValueCode, ValuePool)
)
go


/*==============================================================*/
/* Table: Value                                                 */
/*==============================================================*/
create table dbo.Value (
   ValuePool            varchar(20)          not null,
   ValueCode            varchar(20)          not null,
   SortCode             varchar(20)          not null,
   ValueTextS           varchar(250)         null,
   ValueTextL           varchar(250)         null,
   Footnote             char(1)              not null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint Value_pk primary key clustered (ValuePool, ValueCode)
)
go


/*==============================================================*/
/* Table: ValueExtra                                            */
/*==============================================================*/
create table dbo.ValueExtra (
   ValuePool            varchar(20)          not null,
   ValueCode            varchar(20)          not null,
   Unit                 varchar(30)          null,
   ValueTextX1          varchar(255)         null,
   ValueTextX2          varchar(255)         null,
   ValueTextX3          varchar(255)         null,
   ValueTextX4          varchar(255)         null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint ValueExtra_pk primary key clustered (ValuePool, ValueCode)
)
go


/*==============================================================*/
/* Table: ValueExtra_Eng                                        */
/*==============================================================*/
create table ValueExtra_Eng (
   ValuePool            varchar(20)          not null,
   ValueCode            varchar(20)          not null,
   Unit                 varchar(30)          null,
   ValueTextX1          varchar(255)         null,
   ValueTextX2          varchar(255)         null,
   ValueTextX3          varchar(255)         null,
   ValueTextX4          varchar(255)         null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint ValueExtra_Eng_pk unique (ValuePool, ValueCode)
)
go


/*==============================================================*/
/* Table: ValuePool                                             */
/*==============================================================*/
create table dbo.ValuePool (
   ValuePool            varchar(20)          not null,
   PresText             varchar(80)          null,
   Description          varchar(200)         not null,
   ValueTextExists      char(1)              not null,
   ValuePres            char(1)              not null,
   KDBid                varchar(20)          null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint ValuePool_pk primary key clustered (ValuePool)
)
go


/*==============================================================*/
/* Table: ValuePool_Eng                                         */
/*==============================================================*/
create table dbo.ValuePool_Eng (
   ValuePool            varchar(20)          not null,
   ValuePoolEng         varchar(20)          not null,
   PresText             varchar(80)          null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint ValuePool_Eng_pk primary key clustered (ValuePool)
)
go


/*==============================================================*/
/* Table: ValueSet                                              */
/*==============================================================*/
create table dbo.ValueSet (
   ValueSet             varchar(30)          not null,
   PresText             varchar(80)          null,
   Description          varchar(200)         not null,
   Elimination          varchar(20)          not null,
   ValuePool            varchar(20)          not null,
   ValuePres            char(1)              not null,
   GeoAreaNo            smallint             null,
   KDBid                varchar(20)          null,
   SortCodeExists       char(1)              not null,
   Footnote             char(1)              not null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint ValueSet_pk primary key clustered (ValueSet)
)
go


/*==============================================================*/
/* Table: ValueSet_Eng                                          */
/*==============================================================*/
create table ValueSet_Eng (
   ValueSet             varchar(30)          not null,
   PresText             varchar(80)          null,
   Description          varchar(200)         not null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint ValueSet_Eng_pk primary key  (ValueSet)
)
go


/*==============================================================*/
/* Table: Value_Eng                                             */
/*==============================================================*/
create table dbo.Value_Eng (
   ValuePool            varchar(20)          not null,
   ValueCode            varchar(20)          not null,
   SortCode             varchar(20)          not null,
   ValuetextS           varchar(250)         null,
   ValuetextL           varchar(250)         null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint Value_Eng_pk primary key clustered (ValuePool, ValueCode)
)
go


/*==============================================================*/
/* Table: Variable                                              */
/*==============================================================*/
create table dbo.Variable (
   Variable             varchar(20)          not null,
   PresText             varchar(80)          not null,
   VariableInfo         varchar(200)         null,
   Footnote             char(1)              not null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint Variable_pk primary key clustered (Variable)
)
go


/*==============================================================*/
/* Table: Variable_Eng                                          */
/*==============================================================*/
create table dbo.Variable_Eng (
   Variable             varchar(20)          not null,
   PresText             varchar(80)          not null,
   UserId               varchar(20)          not null,
   LogDate              smalldatetime        not null,
   constraint Variable_Eng_pk primary key clustered (Variable)
)
go


alter table dbo.ColumnCode_Eng
   add constraint ColumnCode_Eng_fk1 foreign key (MetaTable, ColumnName, Code)
      references dbo.ColumnCode (MetaTable, ColumnName, Code)
go


alter table dbo.Contents
   add constraint Contents_fk1 foreign key (MainTable)
      references dbo.MainTable (MainTable)
go


alter table dbo.Contents
   add constraint Contents_fk3 foreign key (StatAuthority)
      references dbo.Organization (OrganizationCode)
go


alter table dbo.Contents
   add constraint Contents_fk4 foreign key (Producer)
      references dbo.Organization (OrganizationCode)
go


alter table dbo.ContentsTime
   add constraint ContentsTime_fk1 foreign key (MainTable, Contents)
      references dbo.Contents (MainTable, Contents)
go


alter table dbo.Contents_Eng
   add constraint Contents_Eng_fk1 foreign key (MainTable, Contents)
      references dbo.Contents (MainTable, Contents)
go


alter table dbo.FootnoteContTime
   add constraint FootnoteContTime_fk1 foreign key (FootnoteNo)
      references dbo.Footnote (FootnoteNo)
go


alter table dbo.FootnoteContTime
   add constraint FootnoteContTime_fk2 foreign key (MainTable, Contents, TimePeriod)
      references dbo.ContentsTime (MainTable, Contents, TimePeriod)
go


alter table dbo.FootnoteContValue
   add constraint FootnoteContValue_fk1 foreign key (FootnoteNo)
      references dbo.Footnote (FootnoteNo)
go


alter table dbo.FootnoteContValue
   add constraint FootnoteContValue_fk2 foreign key (MainTable, Contents)
      references dbo.Contents (MainTable, Contents)
go


alter table dbo.FootnoteContValue
   add constraint FootnoteContValue_fk3 foreign key (ValuePool, ValueCode)
      references dbo.Value (ValuePool, ValueCode)
go


alter table dbo.FootnoteContValue
   add constraint FootnoteContValue_fk4 foreign key (Variable)
      references dbo.Variable (Variable)
go


alter table dbo.FootnoteContVbl
   add constraint FootnoteContVbl_fk1 foreign key (FootnoteNo)
      references dbo.Footnote (FootnoteNo)
go


alter table dbo.FootnoteContVbl
   add constraint FootnoteContVbl_fk2 foreign key (MainTable, Contents)
      references dbo.Contents (MainTable, Contents)
go


alter table dbo.FootnoteContVbl
   add constraint FootnoteContVbl_fk3 foreign key (Variable)
      references dbo.Variable (Variable)
go


alter table dbo.FootnoteContents
   add constraint FootnoteContents_fk1 foreign key (FootnoteNo)
      references dbo.Footnote (FootnoteNo)
go


alter table dbo.FootnoteContents
   add constraint FootnoteContents_fk2 foreign key (MainTable, Contents)
      references dbo.Contents (MainTable, Contents)
go


alter table FootnoteMainTable
   add constraint FootnoteMainTable_fk1 foreign key (MainTable)
      references dbo.MainTable (MainTable)
go


alter table FootnoteMainTable
   add constraint FootnoteMainTable_fk2 foreign key (FootnoteNo)
      references dbo.Footnote (FootnoteNo)
go


alter table dbo.FootnoteMaintValue
   add constraint FK_FootnoteMaint_MainTable foreign key (MainTable)
      references dbo.MainTable (MainTable)
go


alter table dbo.FootnoteMaintValue
   add constraint FK_FootnoteMaint_Variable foreign key (Variable)
      references dbo.Variable (Variable)
go


alter table dbo.FootnoteMaintValue
   add constraint FK_FootnoteMaint_Value foreign key (ValuePool, ValueCode)
      references dbo.Value (ValuePool, ValueCode)
go


alter table dbo.FootnoteMaintValue
   add constraint FK_FootnoteMaint_Footnote foreign key (FootnoteNo)
      references dbo.Footnote (FootnoteNo)
go


alter table dbo.FootnoteMenuSel
   add constraint FootnoteMenuSel_fk1 foreign key (FootnoteNo)
      references dbo.Footnote (FootnoteNo)
go


alter table dbo.FootnoteMenuSel
   add constraint FootnoteMenuSel_fk2 foreign key (Menu, Selection)
      references dbo.MenuSelection (Menu, Selection)
go


alter table FootnoteSubTable
   add constraint FK_FootnoteSubTa_Footnote foreign key (FootnoteNo)
      references dbo.Footnote (FootnoteNo)
go


alter table FootnoteSubTable
   add constraint FK_FootnoteSubTa_SubTable foreign key (MainTable, SubTable)
      references dbo.SubTable (MainTable, SubTable)
go


alter table dbo.FootnoteValue
   add constraint FootnoteValue_fk1 foreign key (FootnoteNo)
      references dbo.Footnote (FootnoteNo)
go


alter table dbo.FootnoteValue
   add constraint FootnoteValue_fk2 foreign key (ValuePool, ValueCode)
      references dbo.Value (ValuePool, ValueCode)
go


alter table dbo.FootnoteVariable
   add constraint FootnoteVariable_fk1 foreign key (FootnoteNo)
      references dbo.Footnote (FootnoteNo)
go


alter table dbo.FootnoteVariable
   add constraint FootnoteVariable_fk2 foreign key (Variable)
      references dbo.Variable (Variable)
go


alter table dbo.Footnote_Eng
   add constraint Footnote_Eng_fk1 foreign key (FootnoteNo)
      references dbo.Footnote (FootnoteNo)
go


alter table dbo.Grouping
   add constraint Grouping_fk1 foreign key (ValuePool)
      references dbo.ValuePool (ValuePool)
go


alter table dbo.Grouping_Eng
   add constraint Grouping_Eng_fk1 foreign key (ValuePool, Grouping)
      references dbo.Grouping (ValuePool, Grouping)
go


alter table LinkMenuSelection
   add constraint LinkMenuSelection_fk1 foreign key (LinkId)
      references Link (LinkId)
go


alter table LinkMenuSelection
   add constraint LinkMenuSelection_fk2 foreign key (Menu, Selection)
      references dbo.MenuSelection (Menu, Selection)
go


alter table Link_Eng
   add constraint Link_Eng_fk1 foreign key (LinkId)
      references Link (LinkId)
go


alter table dbo.MainTable
   add constraint MainTable_fk1 foreign key (TimeScale)
      references dbo.TimeScale (TimeScale)
go


alter table dbo.MainTable
   add constraint MainTable_fk2 foreign key (ProductId)
      references DataStorage (ProductId)
go


alter table MainTablePerson
   add constraint MainTablePerson_fk1 foreign key (PersonCode)
      references dbo.Person (PersonCode)
go


alter table MainTablePerson
   add constraint MainTablePerson_fk2 foreign key (MainTable)
      references dbo.MainTable (MainTable)
go


alter table dbo.MainTable_Eng
   add constraint MainTable_Eng_fk1 foreign key (MainTable)
      references dbo.MainTable (MainTable)
go


alter table dbo.MenuSelection_Eng
   add constraint MenuSelection_Eng_fk1 foreign key (Menu, Selection)
      references dbo.MenuSelection (Menu, Selection)
go


alter table dbo.Organization_Eng
   add constraint Organization_Eng_fk1 foreign key (OrganizationCode)
      references dbo.Organization (OrganizationCode)
go


alter table dbo.Person
   add constraint Person_fk1 foreign key (OrganizationCode)
      references dbo.Organization (OrganizationCode)
go


alter table SpecialCharacter_Eng
   add constraint SpecialCharacter_Eng_fk1 foreign key (CharacterType)
      references SpecialCharacter (CharacterType)
go


alter table dbo.SubTable
   add constraint SubTable_fk1 foreign key (MainTable)
      references dbo.MainTable (MainTable)
go


alter table dbo.SubTableVariable
   add constraint SubTableVariable_fk1 foreign key (MainTable, SubTable)
      references dbo.SubTable (MainTable, SubTable)
go


alter table dbo.SubTableVariable
   add constraint SubTableVariable_fk2 foreign key (ValueSet)
      references dbo.ValueSet (ValueSet)
go


alter table dbo.SubTableVariable
   add constraint SubTableVariable_fk3 foreign key (Variable)
      references dbo.Variable (Variable)
go


alter table dbo.SubTable_Eng
   add constraint SubTable_Eng_fk1 foreign key (MainTable, SubTable)
      references dbo.SubTable (MainTable, SubTable)
go


alter table TextCatalog_Eng
   add constraint FK_TextCatalog_E_TextCatalog foreign key (TextCatalogNo)
      references TextCatalog (TextCatalogNo)
go


alter table dbo.TimeScale_Eng
   add constraint TimeScale_Eng_fk1 foreign key (TimeScale)
      references dbo.TimeScale (TimeScale)
go


alter table dbo.VSGroup
   add constraint VSGroup_fk1 foreign key (ValuePool, Grouping)
      references dbo.Grouping (ValuePool, Grouping)
go


alter table dbo.VSGroup
   add constraint VSGroup_fk2 foreign key (ValueSet, ValuePool, ValueCode)
      references dbo.VSValue (ValueSet, ValuePool, ValueCode)
go


alter table dbo.VSGroup
   add constraint VSGroup_fk3 foreign key (ValuePool, ValueCode)
      references dbo.Value (ValuePool, ValueCode)
go


alter table dbo.VSGroup_Eng
   add constraint VSGroup_Eng_fk1 foreign key (ValueSet, Grouping, GroupCode, ValueCode, ValuePool)
      references dbo.VSGroup (ValueSet, Grouping, GroupCode, ValueCode, ValuePool)
go


alter table dbo.VSValue
   add constraint VSValue_fk1 foreign key (ValuePool, ValueCode)
      references dbo.Value (ValuePool, ValueCode)
go


alter table dbo.VSValue
   add constraint VSValue_fk2 foreign key (ValueSet)
      references dbo.ValueSet (ValueSet)
go


alter table VSValue_Eng
   add constraint VSValue_Eng_fk foreign key (ValueSet, ValuePool, ValueCode)
      references dbo.VSValue (ValueSet, ValuePool, ValueCode)
go


alter table dbo.Value
   add constraint Value_fk1 foreign key (ValuePool)
      references dbo.ValuePool (ValuePool)
go


alter table dbo.ValueExtra
   add constraint ValueExtra_fk1 foreign key (ValuePool, ValueCode)
      references dbo.Value (ValuePool, ValueCode)
go


alter table ValueExtra_Eng
   add constraint ValueExtra_Eng_fk foreign key (ValuePool, ValueCode)
      references dbo.ValueExtra (ValuePool, ValueCode)
go


alter table dbo.ValuePool_Eng
   add constraint ValuePool_Eng_Eng_fk1 foreign key (ValuePool)
      references dbo.ValuePool (ValuePool)
go


alter table dbo.ValueSet
   add constraint ValueSet_fk1 foreign key (ValuePool)
      references dbo.ValuePool (ValuePool)
go


alter table ValueSet_Eng
   add constraint ValueSet_Eng_fk1 foreign key (ValueSet)
      references dbo.ValueSet (ValueSet)
go


alter table dbo.Value_Eng
   add constraint Value_Eng_fk1 foreign key (ValuePool, ValueCode)
      references dbo.Value (ValuePool, ValueCode)
go


alter table dbo.Variable_Eng
   add constraint Variable_Eng_fk1 foreign key (Variable)
      references dbo.Variable (Variable)
go
