using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

//========================================
//##			������ ���� MVC			##
//========================================
/*
	MVC(Model-View-Controller) ���� :
	����� �������̽�, ������, �������� �и��Ͽ� ���α׷��� �����ϴ� ����

	���� :
	Model
		���α׷��� ������
		Controller�� ���� ����
		�������� ������ View���� �˸�

	View
		����� �������̽�
		Model�� �����͸� ������� ����ڿ��� ���� ǥ��
		����ڿ��� �Է��� �޾� Controller���� �˸�

	Controller	: 
		������
		View�� �Է��� �޾� �������� ó��
		�������� ����� Model�� ����

	���� :
	1. �������� �� ���� �ܼ��ϰ� ��������
	2. ���α׷��� ���� ��Ҹ� ������� ���� ��ĥ �� �ֵ��� ����
	3. ����������, ���ø����̼��� Ȯ�强, �������� �ڵ����뼺�� ������

	���� :
	1. Model�� View�� �������� ����

	�׿� :
	MVC ������ �Ļ����� MVP(Model-View-Presenter), MVVM(Model-View-ViewModel) ������ ����
*/

public class Model
{
    private int data;
    public int Data
    {
        set
        {
            Debug.Log("[Model] Model changed event");
            OnDataChanged?.Invoke(value);
            data = value;
        }
        get
        {
            return data;
        }
    }

    public UnityAction<int> OnDataChanged;
}

public class View
{
    public UnityAction OnInputed;

    public void UpdateData(int data)
    {
        Debug.Log("[View] Set data");
    }

    public void Input()
    {
        Debug.Log("[View] Detect input");
        OnInputed?.Invoke();
    }
}

public class Controller
{
    public Model data;

    public void Logic()
    {
        Debug.Log("[Controller] Logic");
        data.Data += 1;
    }
}

public class MVCTester
{
    public void Test()
    {
        Model model = new Model();
        View view = new View();
        Controller controller = new Controller();

        model.OnDataChanged += view.UpdateData;
        view.OnInputed += controller.Logic;
        controller.data = model;

        view.Input();
        // 1. [View] Dectect input
        // 2. [Controller] Logic
        // 3. [Model] Model change event
        // 4. [View] Set Data
    }
}