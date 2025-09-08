using System;
using System.Collections.Generic;
using UnityEngine;

public class MarkerDrawingScript : MonoBehaviour
{
    public LineRenderer line;
    public LinkedList<Vector3> points = new LinkedList<Vector3>();
    public GameObject target;
    private Vector3 last_target_position = Vector3.zero;
    public bool is_drawing = false;
    private int current_point_index = -1;

    [SerializeField] public float drawing_time_interval = .05f;
    private float last_draw_time = -1;
    [SerializeField] public float clear_interval = 3f;
    private float last_clear_interval = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        last_target_position = target.transform.position;
        line.positionCount = 0;
        create_new_spot();
        last_draw_time = 0;

    }

    // Update is called once per frame
    void Update()
    {
        last_target_position = target.transform.position;
        last_draw_time += Time.deltaTime;
        last_clear_interval += Time.deltaTime;
        if (is_drawing)
        {
            if (last_draw_time >= drawing_time_interval)
            {
                create_new_spot();
            }

        }
        if (last_clear_interval >= clear_interval)
        {
            Debug.Log("clearing points!");
            clear_points();
            create_new_spot();
            last_clear_interval = 0;
        }
    }

    public void clear_points()
    {
        line.positionCount = 0;
        current_point_index = -1;
        
    }

    public void create_new_spot()
    {
        last_draw_time = 0;
        current_point_index++;
        line.positionCount += 1;
        line.SetPosition(current_point_index, last_target_position);
    }

    public void update_line_positions(Vector3 correction_vector)
    {
        for (int i = 0; i < line.positionCount; i++)
        {
            Vector3 line_position = line.GetPosition(i);
            Vector3 new_position = line_position + correction_vector;
            line.SetPosition(i, new_position);
        }
    }

    public void start_drawing()
    {
        is_drawing = true;
        create_new_spot();

    }
    public void stop_drawing()
    {
        is_drawing = false;
    }
    public void erase_line()
    {
        clear_points(); 
    }

}
