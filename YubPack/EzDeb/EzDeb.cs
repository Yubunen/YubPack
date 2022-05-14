using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YubPack.EzDebug {
    public class ObjectSetter {
        public GameObject cube;
        public GameObject sphire;
        public GameObject line;

        List<GameObject> gameObjects = new List<GameObject>();

        public ObjectSetter() {

        }

        public void setCube(Vector3 vector3) {
            if(cube == null) {
                GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
                obj.transform.position = vector3;
                gameObjects.Add(obj);
            } else {
                GameObject.Instantiate(cube, vector3, Quaternion.identity);
            }
        }

        public void setSphere(Vector3 vector3) {
            if (sphire == null) {
                GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                obj.transform.position = vector3;
                obj.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
                gameObjects.Add(obj);
            } else {
                GameObject.Instantiate(sphire, vector3, Quaternion.identity);
            }
        }

        public void setLine(Vector3 vector3, Vector3 vector31) {
            if (line == null) {
                GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
                obj.transform.position = (vector3 + vector31) / 2;
                Quaternion qua = Quaternion.LookRotation(vector31 - vector3);
                obj.transform.rotation = qua;
                obj.transform.localScale = new Vector3(0.1f, 0.1f, Vector3.Distance(vector3, vector31));
                gameObjects.Add(obj);
            } else {
                GameObject.Instantiate(line, vector3, Quaternion.identity);
            }
        }
    }

    public class MyNums {
        private List<int> numbers;

        public MyNums() {
            numbers = new List<int>();
        }

        public List<int> GetNumbers() {
            return numbers;
        }

        public void Add(int number) {
            numbers.Add(number);
        }

        public void Remove(int number) {
            if (numbers.Contains(number)) {
                numbers.RemoveAt(numbers.IndexOf(number));
            }
        }

        public int Count {
            get { return numbers.Count; }
        }

        public void Clear() {
            numbers.Clear();
        }

        public bool Contains(int number) {
            return numbers.Contains(number);
        }

        public int Sum() {
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++) {
                sum += numbers[i];
            }
            return sum;
        }

        public float Average() {
            return (float)Sum() / numbers.Count;
        }
    }

    public class UIConsole {
        [SerializeField] private GameObject TextBox;
        private string a;

        public UIConsole() {

        }

        public void add(string a) {

        }
    }
}