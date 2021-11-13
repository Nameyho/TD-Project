#if UNITY_EDITOR
using UnityEditor;
using System.IO;
using UnityEngine;



public class MobElementEditor : MonoBehaviour
{

    private static string[] _elements;


    #region Methods
    [MenuItem( "Tools/ElementMobRefresh" )]
    public static void Go()
    {
        string enumName = "MobElement";
        string[] content = File.ReadAllLines("./Assets/Mathieu/Scripts/Enums/MobElement.csv");  
        

        Debug.Log(content);
        string[] enumEntries = _elements ;
        string filePathAndName = "./Assets/Mathieu/Scripts/Enums/" + enumName + ".cs"; //The folder Scripts/Enums/ is expected to exist
 
        using ( StreamWriter streamWriter = new StreamWriter( filePathAndName ) )
        {
             streamWriter.WriteLine( "public enum " + enumName );
             streamWriter.WriteLine( "{" );
             for( int i = 0; i < content.Length; i++ )
             {
                 streamWriter.WriteLine( "\t" + content[i] + "," );
             }
             streamWriter.WriteLine( "}" );
        }
         AssetDatabase.Refresh();
    }
#endregion
 }
#endif

