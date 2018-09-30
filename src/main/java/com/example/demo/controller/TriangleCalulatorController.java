package com.example.demo.controller;

import com.example.demo.entity.Triangle;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("/_api/v1/triangle")
public class TriangleCalulatorController {
    private double p;
    private double s;

    public TriangleCalulatorController() {
    }

    @PostMapping(
            path = {"/heron/"}
    )

    public double area(@RequestBody Triangle triangle){
        p = perimeter(triangle.getFirstSide(),triangle.getSecondSide(),triangle.getThirdSide());
        s = Math.sqrt(p * (p - triangle.getFirstSide()) * (p - triangle.getSecondSide()) * (p - triangle.getThirdSide()));
        return p;
    }

    private double perimeter(double a, double b, double c){
        p = (a + b + c) / 2;
        return p;
    }
}
