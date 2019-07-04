using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodos
{
    class MetodosOrdenacao
    {
        public void SelectSort(int[] A, int T)
        {
            int k;
            int ik;
            int i = 0;
            while (i < T)
            {
                int j = i + 1;
                k = A[i];
                ik = i;
                while (j < T)
                {
                    if (A[j] < k)
                    {
                        k = A[j];
                        ik = j;
                    }
                    j++;
                }
                A[ik] = A[i];
                A[i] = k;
                i++;
            }
        }

        public void BubleSort(int[] A, int T)
        {
            int c = 0;
            int nk = T;
            int k;
            while (c < T)
            {
                int j = 0;
                while (j < nk - 1)
                {
                    if (A[j] > A[j + 1])
                    {
                        k = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = k;
                    }
                    j++;
                }
                nk--;
                c++;
            }
        }

        public void ShellSort(int[] A, int T)
        {
            int h = 1;
            int x;
            int j;
            int i;
            while (h < T)
            {
                h = h * 3 + 1;
            }
            if (h > T)
            {
                h = h / 3;
            }
            while (h > 0)
            {
                i = h;
                while (i < T)
                {
                    x = A[i];
                    j = i;
                    while ((j >= h) && (A[j - h] > x))
                    {
                        A[j] = A[j - h];
                        j = j - h;
                    }
                    A[j] = x;
                    i++;
                }
                h = h / 3;
            }
        }

        public void QuickSort(int[] A, int p, int r)
        {
            int k;
            int i = p;
            int j = r;
            int x = A[(p + r) / 2];
            while (i < j)
            {
                while (A[i] < x)
                {
                    i++;
                }
                while (A[j] > x)
                {
                    j--;
                }
                if (i <= j)
                {
                    k = A[i];
                    A[i] = A[j];
                    A[j] = k;
                    i++;
                    j--;
                }

            }
            if (p < j)
            {
                QuickSort(A, p, j);
            }
            if (i < r)
            {
                QuickSort(A, i, r);
            }
        }
    }
}
