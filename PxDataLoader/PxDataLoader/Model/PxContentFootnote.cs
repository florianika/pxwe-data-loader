using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PxDataLoader.Model
{
    public class PxContentFootnote : PxFootnote
    {

        public PxMainTable MainTable { get; set; }

        public PxContent Content { get; set; }

        public PxContentFootnote()
        {
            FootnoteType = "2";
        }

        public override void CreateEntities(PxMetaModel.PcAxisMetabaseEntities context)
        {
            if (IsNew)
            {
                base.CreateEntities(context);

                PxMetaModel.FootnoteContent footnoteContent = new PxMetaModel.FootnoteContent();

                footnoteContent.MainTable = MainTable.TableId;

                footnoteContent.Contents = Content.Content;

                footnoteContent.FootnoteNo = FootnoteNo;

                footnoteContent.UserId = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                footnoteContent.LogDate = DateTime.Now;

                context.AddToFootnoteContents(footnoteContent);
            }

            else
            {
                base.UpdateEntities(context);
            }

        }

        public override void DeleteEntities(PxMetaModel.PcAxisMetabaseEntities context)
        {
            base.DeleteEntities(context);

            var f = (from c in context.FootnoteContents
                     where c.FootnoteNo == FootnoteNo && c.MainTable == MainTable.TableId && c.Contents == Content.Content
                     select c).FirstOrDefault();
            if (f != null)
            {
                context.DeleteObject(f);
            }
        }

    }
}
