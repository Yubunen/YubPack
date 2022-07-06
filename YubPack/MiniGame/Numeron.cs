namespace YubPack.MiniGame.Numeron
{
    using UnityEngine;

    public class ComPlayer
    {
        private int[] code;
        
        public int Code
        {
            get
            {
                for
            }
        }

        public ComPlayer(int digits = 3)
        {
            code = new int[digits];
            GenerateCode();
        }

        private void GenerateCode()
        {
            int[] vs = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < vs.Length; i++)
            {
                int ind = Random.Range(0, 10);
                int tmp = vs[i];
                vs[i] = vs[ind];
                vs[ind] = tmp;
            }
            for(int i = 0; i < code.Length; i++)
            {
                code[i] = vs[i];
            }
        }
    }
}