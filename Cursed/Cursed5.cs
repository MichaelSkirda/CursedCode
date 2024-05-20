using System;
using System.Reflection;
using cursed.CurseHelpers;
using cursed.Cursed.UselessUsing;
using cursed.Cursed.UselessUsing;

namespace cursed.Cursed
{
    internal class Cursed5 : ICursed
    {
        public static string Name { get; set; } = "CIL Bubble sort";

        public void Curse()
        {
            int[] nums = { 7, 1, 5, 4, 9 };

            Assembly assembly = IL_LoadManagerController.LoadIL(CodeIL);
            Type type = assembly.GetType("HelloApp.Program")!;
            MethodInfo method = type.GetMethod("BubbleSort", BindingFlags.Static | BindingFlags.NonPublic)!;

            method.Invoke(null, new object[] { nums });

            foreach(var num in nums)
                Console.WriteLine(num);
        }


        string CodeIL = // You actually can edit this
@"
.assembly extern System.Runtime
{
    .ver 5:0:0:0
}
.assembly extern System.Console
{
    .ver 5:0:0:0
}

.assembly HelloApp{}
.module HelloApp.dll

.namespace HelloApp
{
	.class private auto Program
	{

	    .method private static void BubbleSort(int32[] arr) cil managed
        {
          // Code size       84 (0x54)
          .maxstack  5
          .locals init (int32 V_0,
                   int32 V_1,
                   int32 V_2,
                   bool V_3,
                   int32 V_4,
                   bool V_5,
                   bool V_6)
          IL_0000:  nop
          IL_0001:  ldarg.0
          IL_0002:  ldlen
          IL_0003:  conv.i4
          IL_0004:  stloc.0
          IL_0005:  ldc.i4.0
          IL_0006:  stloc.1
          IL_0007:  br.s       IL_0047
          IL_0009:  ldc.i4.0
          IL_000a:  stloc.2
          IL_000b:  br.s       IL_0035
          IL_000d:  ldarg.0
          IL_000e:  ldloc.2
          IL_000f:  ldelem.i4
          IL_0010:  ldarg.0
          IL_0011:  ldloc.2
          IL_0012:  ldc.i4.1
          IL_0013:  add
          IL_0014:  ldelem.i4
          IL_0015:  cgt
          IL_0017:  stloc.3
          IL_0018:  ldloc.3
          IL_0019:  brfalse.s  IL_0031
          IL_001b:  nop
          IL_001c:  ldarg.0
          IL_001d:  ldloc.2
          IL_001e:  ldelem.i4
          IL_001f:  stloc.s    V_4
          IL_0021:  ldarg.0
          IL_0022:  ldloc.2
          IL_0023:  ldarg.0
          IL_0024:  ldloc.2
          IL_0025:  ldc.i4.1
          IL_0026:  add
          IL_0027:  ldelem.i4
          IL_0028:  stelem.i4
          IL_0029:  ldarg.0
          IL_002a:  ldloc.2
          IL_002b:  ldc.i4.1
          IL_002c:  add
          IL_002d:  ldloc.s    V_4
          IL_002f:  stelem.i4
          IL_0030:  nop
          IL_0031:  ldloc.2
          IL_0032:  ldc.i4.1
          IL_0033:  add
          IL_0034:  stloc.2
          IL_0035:  ldloc.2
          IL_0036:  ldloc.0
          IL_0037:  ldloc.1
          IL_0038:  sub
          IL_0039:  ldc.i4.1
          IL_003a:  sub
          IL_003b:  clt
          IL_003d:  stloc.s    V_5
          IL_003f:  ldloc.s    V_5
          IL_0041:  brtrue.s   IL_000d
          IL_0043:  ldloc.1
          IL_0044:  ldc.i4.1
          IL_0045:  add
          IL_0046:  stloc.1
          IL_0047:  ldloc.1
          IL_0048:  ldloc.0
          IL_0049:  ldc.i4.1
          IL_004a:  sub
          IL_004b:  clt
          IL_004d:  stloc.s    V_6
          IL_004f:  ldloc.s    V_6
          IL_0051:  brtrue.s   IL_0009
          IL_0053:  ret
        } // end of method Program::BubbleSort

	}
}
";

    }
}
