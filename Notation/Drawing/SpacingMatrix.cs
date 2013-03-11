//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Vivace.Notation.Drawing {
//    /// <summary>
//    /// 
//    /// </summary>
//    [Serializable]
//    public class SpacingMatrix {
//        #region Declarations
//        private int memSize;
//        private int realSize;
//        private double[] matrix;
//        private IntListCollection neighbours = null;
//        private IntListCollection neighboursRight = null;
//        private int lastLeft = 0;
//        private int lastRight = 0;
//        private double oneOverLogTwo = 1.0 / Math.Log(2.0);
//        #endregion

//        #region Constructor
//        public SpacingMatrix() {
//            memSize = 50;
//            realSize = 0;
//            matrix = new double[memSize * NVALUESINMSCMATRIX];
//            matrix.Initialize(); // should set all values to 0
//        }
//        #endregion

//        #region Members
//        public double[] ResizeMSCMatrix(int newrealSize) {
//            if (newrealSize > memSize) {
//                int newMemSize = newrealSize + 10; // pad it out
//                double[] newMatrix = new double[newMemSize * NVALUESINMSCMATRIX];
//                newMatrix.Initialize();

//                int i, j;
//                // copy over existing values
//                for (i = 0; i < memSize; i++) {
//                    for (j = 0; j < NVALUESINMSCMATRIX; j++) {
//                        newMatrix[i + j * newMemSize] = matrix[i + j * memSize];
//                    }
//                }

//                memSize = newMemSize;
//                matrix = newMatrix;
//            }
            
//            realSize = newrealSize;
//            return matrix;
//        }
//        /// <summary>
//        /// 
//        /// </summary>
//        /// <param name="list"></param>
//        public void AddNeighbourList(IntList list) {
//            if (neighbours == null) {
//                neighbours = new IntListCollection();
//                neighbours.Add(list);
//                lastLeft = list[0];

//                neighboursRight = new IntListCollection();
//                neighboursRight.Add(list);
//                lastRight = list[0];

//                return;
//            }

//            int newLeft = list[0];
//            int newRight = list[list.Count - 1];

//            if (newLeft >= lastLeft) {
//                lastLeft = newLeft;
//                neighbours.Add(list);
//                goto addRight;
//            }

//            foreach (IntList curList in neighbours) {
//                int left = curList[0];
//                if (newLeft <= left) {
//                    neighbours.Insert(neighbours.IndexOf(curList), list);
//                    goto addRight;
//                }
//            }
//addRight:
//            if (newRight <= lastRight) {
//                lastRight = newRight;
//                neighboursRight.Add(list);
//                return;
//            }

//            foreach (IntList curList in neighboursRight) {
//                int right;
//                if (curList.Count > 0)
//                    right = curList[curList.Count - 1];
//                else
//                    right = 0;

//                if (newRight >= right) {
//                    neighboursRight.Insert(
//                        neighboursRight.IndexOf(curList), list
//                    );
//                    break;
//                }

//            }
//        }

//        /// <summary>
//        /// Checks wether any neighbours have "funny" spacing; this means that the 
//        /// spring-constants do not match.
//        /// </summary>
//        /// <param name="springList"></param>
//        public void CheckNeighbours(List<Spring> springList) {
//            if (neighbours == null)
//                return;

//            IntListCollection errList = new IntListCollection();

//            foreach (IntList curList in neighbours) {
//                double value = 0.0f;
//                double logvalue = 0;
//                double diffpartial = 0;
//                double checkval = 0.0f;
//                double logcheckval = 0;
//                double average = 0;
//                double numvalues = 0;
//                double theMin = 1e10;
//                double theMax = 0;
//                bool haserror = false;

//                if (curList.Count > 0) {
//                    int i1 = -1;
//                    int i2 = -1;
//                    bool first = true;

//                    for (int i = 0; i < curList.Count; i++) {
//                        i1 = i2;
//                        if (i1 == -1) {
//                            i1 = curList[i];
//                            i++; // prob should check that this doesnt go out of range, tho not sure what to to in that case
//                        }

//                        i2 = curList[i];
//                        checkval = 0.0f;
//                        for (int cnt = i1; cnt < i2; cnt++) {
//                            double val = matrix[cnt + memSize * 3];
//                            if (val < theMin) theMin = val;
//                            if (val > theMax) theMax = val;

//                            checkval += val;
//                            average += val;
//                            ++numvalues;
//                        }

//                        checkval /= (i2 - i1);
//                        logcheckval = Math.Log(checkval) * oneOverLogTwo;

//                        if (first) {
//                            value = checkval;
//                            logvalue = logcheckval;
//                            first = false;
//                        } else {
//                            if (value != checkval) {
//                                double tmpdiff = logcheckval = logvalue;
//                                if (tmpdiff < 0)
//                                    tmpdiff = -tmpdiff;
//                                if (tmpdiff > diffpartial)
//                                    diffpartial = tmpdiff;

//                                haserror = true;
//                            }
//                        }
//                    }

//                    if (haserror) {
//                        average /= numvalues;
//                        errList.Add(curList);
//                    }
//                }
//            }

//            if (errList.Count == 0)
//                return;

//            IntListCollection errList2 = new IntListCollection();
//            int lstleft = -1;
//            foreach (IntList lst in errList) {
//                int left = lst[0];
//                int right = lst[lst.Count - 1];

//                foreach (IntList nbrs in neighbours) {
//                    int nbrLeft = nbrs[0];
//                    int nbrRight = nbrs[nbrs.Count - 1];

//                    if (nbrRight > left && nbrLeft < right) {
//                        if (nbrRight > right)
//                            right = nbrRight;
//                    }
//                }

//                foreach (IntList nbrs in neighboursRight) {
//                    int nbrLeft = nbrs[0];
//                    int nbrRight = nbrs[nbrs.Count - 1];

//                    if (nbrRight > left && nbrLeft < right) {
//                        if (nbrLeft < left)
//                            left = nbrLeft;
//                    }

//                }

//                if (left != lstleft) {
//                    IntList newList = new IntList();
//                    newList.Add(left);
//                    newList.Add(right);
//                    errList2.Add(newList);
//                    lastLeft = left;
//                }
//            }

//            foreach (IntList intlist in errList2) {
//                int left = intlist[0];
//                int right = intlist[intlist.Count - 1];

//                double average = 0;
//                double max = 0;
//                double oldconst = 0;
//                double sumsprdur = 0;
//                double newmaxconst = 0;
//                double newaverageconst = 0;
//                bool first = true;

//                for (int cnt = left; cnt < right; cnt++) {
//                    double val = matrix[cnt + memSize * 3];
//                    Spring spr = springList[cnt];

//                    Fraction myfrac = new Fraction(val);
//                    Fraction dur = spr.Duration;
//                    myfrac = myfrac.Inverse();
//                    double sconst = Spring.DefaultConstant(myfrac);
//                    sconst *= (double)myfrac / (double)dur;

//                    if (first) {
//                        oldconst = sconst;
//                        first = false;
//                    } else {
//                        oldconst = (oldconst * sconst) / (oldconst + sconst);
//                    }
//                    sumsprdur += (double)dur;

//                    average += matrix[cnt + memSize * 3];
//                    if (matrix[cnt + memSize * 3] > max)
//                        max = matrix[cnt + memSize * 3];
//                }

//                average /= (right - left);
//                Fraction frac2 = new Fraction(max);
//                frac2 = frac2.Inverse();

//            }
//        }
//        #endregion

//        #region Properties
//        /// <summary>
//        /// Indexer for getting/ setting matrix values
//        /// </summary>
//        /// <param name="i"></param>
//        /// <param name="j"></param>
//        /// <returns></returns>
//        public double this[int i, int j] {
//            get {
//                if (i >= 0 && i < realSize && j >= 0 && j < NVALUESINMSCMATRIX)
//                    return matrix[i + j * memSize];
//                else
//                    return 0;
//            }

//            set {
//                if (i >= 0 && i < realSize && j >= 0 && j < NVALUESINMSCMATRIX)
//                    matrix[i + j * memSize] = value;
//            }
//        }

//        public int MemSize {
//            get {
//                return memSize;
//            }
//        }

//        public int RealSize {
//            get {
//                return realSize;
//            }
//        }
//        #endregion

//        #region Constants
//        private const int NVALUESINMSCMATRIX = 6;
//        #endregion
//    }

//    #region Utility classes
//    public class IntList : List<Int32> {
//    }
//    public class IntListCollection : List<IntList> {
//    }
//    #endregion
//}
