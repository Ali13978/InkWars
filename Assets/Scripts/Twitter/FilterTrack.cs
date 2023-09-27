using UnityEngine;

namespace Twitter
{
    public class FilterTrack
    {
        // Fields
        private System.Collections.Generic.List<string> tracks;
        
        // Methods
        public FilterTrack(string track)
        {
            System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
            this.tracks = val_1;
            val_1.Add(item:  track);
        }
        public FilterTrack(System.Collections.Generic.List<string> tracks)
        {
            this.tracks = tracks;
        }
        public void AddTrack(string track)
        {
            this.tracks.Add(item:  track);
        }
        public void AddTracks(System.Collections.Generic.List<string> tracks)
        {
            var val_3 = this;
            List.Enumerator<T> val_1 = tracks.GetEnumerator();
            label_4:
            if(((-1202049688) & 1) == 0)
            {
                goto label_2;
            }
            
            this.tracks.Add(item:  0.InitialType);
            goto label_4;
            label_2:
            0.Add(driver:  public System.Void List.Enumerator<System.String>::Dispose(), rectTransform:  null, drivenProperties:  null);
        }
        public string GetKey()
        {
            return "track";
        }
        public string GetValue()
        {
            int val_10;
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
            List.Enumerator<T> val_2 = this.tracks.GetEnumerator();
            label_4:
            if(((-1201792840) & 1) == 0)
            {
                goto label_2;
            }
            
            System.Text.StringBuilder val_5 = val_1.Append(value:  0.InitialType + ",");
            goto label_4;
            label_2:
            0.Add(driver:  public System.Void List.Enumerator<System.String>::Dispose(), rectTransform:  null, drivenProperties:  null);
            if(val_1 == null)
            {
                
            }
            else
            {
                    val_10 = val_1.Length - 1;
                val_1.Length = val_10;
                return (string)val_1;
            }
            
            val_10 = val_1.Length - 1;
            val_1.Length = val_10;
            return (string)val_1;
        }
    
    }

}
