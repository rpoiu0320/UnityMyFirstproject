using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityUI : MonoBehaviour
{
    /************************************************************************
	 * ����� �������̽� (User Interface)
	 * 
	 * ������ ���α׷��� �ǻ������ �� �� �ֵ��� ���� �Ű�ü
	 * ��ư, ��ũ��, �ؽ�Ʈ �� ����Ʈ���������� ����Ƽ�� ����ۿ� �� �� �ִ� ����
	 * Hierarchy�� ���� �ִ� UI���� �� ������ ���� �� 
	 ************************************************************************/

    // <ĵ����>
    // UI ��ҵ��� ������ �ִ� UI ����Ʋ
    // ��� UI ��Ҵ� ĵ���� �ȿ� ��ġ�ؾ� ��
    // ��ġ�� ��ĥ ��� ���߿� �׷����� UI ��Ұ� ���� UI ��Ҹ� ���
    // ũ��� ȭ��� ����

    // <�⺻ ���̾ƿ�>
    // Rect Transform : UI ������Ʈ�� �⺻ ������ҷ� �Ϲ� Transform ������Ʈ ��� ����
    //					Rect Transform�� Transform�� ����� ����Ŭ������ Transform�� ��� ����� ����
    //					�߰������� �簢���� ũ�⸦ �����ϱ� ���� ��, ����, UI�� ������ ��Ŀ, �ǹ��� ����
    // ��Ŀ(Anchor) : �ڽ�������Ʈ�� �θ� �����ġ�� ���� ���� ����, ȭ��񸶴� UIâ�� �ٸ��� �����°� �����ϱ� ���ؼ� ���� ��ġ �� ũ�⸦ ��������
    // �ǹ�(Pivot) : ��ġ, ȸ��, ũ���� �߽� ��ġ

    // <UI ������Ʈ>
    // ���־� ������Ʈ : ���� ǥ�ø��� ���� ������Ʈ (�ؽ�Ʈ, �̹���, ��)
    // ��ȣ�ۿ� ������Ʈ : ���콺 �� ��ġ �̺�Ʈ ���� ����Ͽ� �̷������ ��ȣ�ۿ��� ó���ϴ� UI �ý����� ������Ʈ
    //					  ��ȣ�ۿ� ������Ʈ ��ü�� ����ڿ��� �������� �����Ƿ�, �ϳ� �̻��� ���־� ������Ʈ�� �����Ͽ� ���
    //					  (��ư, ���, ��� �׷�, �����̴�, ��ũ�ѹ�, ��Ӵٿ�, �Է��ʵ�, ��ũ�Ѻ� ��)
    //					  �Է� �̺�Ʈ�� �����ϱ� ���ؼ� ���Ӿ� ���� Event System ������Ʈ�� �ʿ���

    // <Event System>
    // Ű����, ���콺, ��ġ, Ŀ���� �Է� �� �Է� ��� ���ø����̼��� ������Ʈ�� �̺�Ʈ�� �����ϴ� ���
    // UI�� �߰��ϴ� ��� �ڵ����� ���� ���Ե�����, ��Ÿ�� ��ÿ� UI�� �����ϴ� ��쿡 ����
}